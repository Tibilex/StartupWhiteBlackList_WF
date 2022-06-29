using System.Diagnostics;

namespace StartupWhiteBlackList_WF
{
    public partial class Form1 : Form
    {
        private string _target = @"C:\Users\ibozi\AppData\Local\Programs\Opera GX\opera.exe";
        public Form1()
        {
            InitializeComponent();

            _addToWhiteBtn.Click += AddToWhiteList;
            _addToBlackBtn.Click += AddToBlackList;
            _removeInWhiteBtn.Click += RemoveInWhiteList;
            _removeInBlackBtn.Click += RemoveInBlackList;
            //_whiteListBox.Items.Add(_target);
        }

        private void RemoveInBlackList(object? sender, EventArgs e)
        {
            _blackListBox.Items.Remove(_blackListBox.SelectedItem);           
        }

        private void RemoveInWhiteList(object? sender, EventArgs e)
        {
            _whiteListBox.Items.Remove(_whiteListBox.SelectedItem);
        }

        private void AddToBlackList(object? sender, EventArgs e)
        {
            if (_blackTextBox.Text != "")
            {
                _blackListBox.Items.Add(_blackTextBox.Text);
                _blackTextBox.Text = "";
            }
        }

        private void AddToWhiteList(object? sender, EventArgs e)
        {        
            if (_whiteTextBox.Text != "")
            {
                _whiteListBox.Items.Add(_whiteTextBox.Text);
                _whiteTextBox.Text = "";
            }
        }

        private async void CheckingLists(ListBox white, ListBox black) 
        {
            string[] whitelList = white.Items.OfType<string>().ToArray();
            string[] blacklList = black.Items.OfType<string>().ToArray();
            while (true)
            {
                await Task.Delay(1000);
                if(blacklList != null)
                {
                    foreach(var item in blacklList)
                    {
                        foreach(var process in Process.GetProcessesByName(item))
                        {
                            Thread.Sleep(1000);
                            process.Kill();
                        }
                    }
                }
                foreach (var item in whitelList)
                {
                    if(Process.GetProcessesByName(item).Length != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Process process = new Process();
                        process.StartInfo = new ProcessStartInfo(item);
                        process.Start();
                    }
                }
            }
            
        }

        private void StartBtn(object sender, EventArgs e)
        {
            if(CheckLists(_whiteListBox, _blackListBox) != true)
            {
                if(_whiteListBox.Items.Count != 0 || _blackListBox.Items.Count != 0)
                {
                    CheckingLists(_whiteListBox, _blackListBox);
                }
                else
                {
                    MessageBox.Show("Списки пуcты!");
                }
            }
            else
            {
                MessageBox.Show("В списках есть одинаковые запросы");
            }
        }

        private bool CheckLists(ListBox white, ListBox black)
        {
            var matching = white.Items.Cast<string>().Except(black.Items.Cast<string>());
            if (matching == null) { return true; }
            else { return false; }
        }
    }
}
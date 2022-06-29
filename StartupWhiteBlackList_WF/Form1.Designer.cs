namespace StartupWhiteBlackList_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._whiteGroupBox = new System.Windows.Forms.GroupBox();
            this._whiteTextBox = new System.Windows.Forms.TextBox();
            this._addToWhiteBtn = new System.Windows.Forms.Button();
            this._removeInWhiteBtn = new System.Windows.Forms.Button();
            this._whiteListBox = new System.Windows.Forms.ListBox();
            this._blackGroupBox = new System.Windows.Forms.GroupBox();
            this._blackTextBox = new System.Windows.Forms.TextBox();
            this._addToBlackBtn = new System.Windows.Forms.Button();
            this._removeInBlackBtn = new System.Windows.Forms.Button();
            this._blackListBox = new System.Windows.Forms.ListBox();
            this._startBtn = new System.Windows.Forms.Button();
            this._whiteGroupBox.SuspendLayout();
            this._blackGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _whiteGroupBox
            // 
            this._whiteGroupBox.Controls.Add(this._whiteTextBox);
            this._whiteGroupBox.Controls.Add(this._addToWhiteBtn);
            this._whiteGroupBox.Controls.Add(this._removeInWhiteBtn);
            this._whiteGroupBox.Controls.Add(this._whiteListBox);
            this._whiteGroupBox.ForeColor = System.Drawing.Color.White;
            this._whiteGroupBox.Location = new System.Drawing.Point(12, 12);
            this._whiteGroupBox.Name = "_whiteGroupBox";
            this._whiteGroupBox.Size = new System.Drawing.Size(200, 400);
            this._whiteGroupBox.TabIndex = 0;
            this._whiteGroupBox.TabStop = false;
            this._whiteGroupBox.Text = "WhiteList";
            // 
            // _whiteTextBox
            // 
            this._whiteTextBox.Location = new System.Drawing.Point(10, 269);
            this._whiteTextBox.Name = "_whiteTextBox";
            this._whiteTextBox.Size = new System.Drawing.Size(180, 23);
            this._whiteTextBox.TabIndex = 2;
            // 
            // _addToWhiteBtn
            // 
            this._addToWhiteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(78)))));
            this._addToWhiteBtn.ForeColor = System.Drawing.Color.White;
            this._addToWhiteBtn.Location = new System.Drawing.Point(10, 300);
            this._addToWhiteBtn.Name = "_addToWhiteBtn";
            this._addToWhiteBtn.Size = new System.Drawing.Size(180, 40);
            this._addToWhiteBtn.TabIndex = 0;
            this._addToWhiteBtn.Text = "ADD TO LIST";
            this._addToWhiteBtn.UseVisualStyleBackColor = false;
            // 
            // _removeInWhiteBtn
            // 
            this._removeInWhiteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this._removeInWhiteBtn.ForeColor = System.Drawing.Color.White;
            this._removeInWhiteBtn.Location = new System.Drawing.Point(10, 350);
            this._removeInWhiteBtn.Name = "_removeInWhiteBtn";
            this._removeInWhiteBtn.Size = new System.Drawing.Size(180, 40);
            this._removeInWhiteBtn.TabIndex = 0;
            this._removeInWhiteBtn.Text = "REMOVE";
            this._removeInWhiteBtn.UseVisualStyleBackColor = false;
            // 
            // _whiteListBox
            // 
            this._whiteListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(70)))));
            this._whiteListBox.ForeColor = System.Drawing.Color.White;
            this._whiteListBox.ItemHeight = 15;
            this._whiteListBox.Location = new System.Drawing.Point(10, 22);
            this._whiteListBox.Name = "_whiteListBox";
            this._whiteListBox.Size = new System.Drawing.Size(180, 244);
            this._whiteListBox.TabIndex = 1;
            // 
            // _blackGroupBox
            // 
            this._blackGroupBox.Controls.Add(this._blackTextBox);
            this._blackGroupBox.Controls.Add(this._addToBlackBtn);
            this._blackGroupBox.Controls.Add(this._removeInBlackBtn);
            this._blackGroupBox.Controls.Add(this._blackListBox);
            this._blackGroupBox.ForeColor = System.Drawing.Color.White;
            this._blackGroupBox.Location = new System.Drawing.Point(224, 12);
            this._blackGroupBox.Name = "_blackGroupBox";
            this._blackGroupBox.Size = new System.Drawing.Size(200, 400);
            this._blackGroupBox.TabIndex = 0;
            this._blackGroupBox.TabStop = false;
            this._blackGroupBox.Text = "BlackList";
            // 
            // _blackTextBox
            // 
            this._blackTextBox.Location = new System.Drawing.Point(10, 269);
            this._blackTextBox.Name = "_blackTextBox";
            this._blackTextBox.Size = new System.Drawing.Size(180, 23);
            this._blackTextBox.TabIndex = 2;
            // 
            // _addToBlackBtn
            // 
            this._addToBlackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(78)))));
            this._addToBlackBtn.ForeColor = System.Drawing.Color.White;
            this._addToBlackBtn.Location = new System.Drawing.Point(10, 300);
            this._addToBlackBtn.Name = "_addToBlackBtn";
            this._addToBlackBtn.Size = new System.Drawing.Size(180, 40);
            this._addToBlackBtn.TabIndex = 0;
            this._addToBlackBtn.Text = "ADD TO LIST";
            this._addToBlackBtn.UseVisualStyleBackColor = false;
            // 
            // _removeInBlackBtn
            // 
            this._removeInBlackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this._removeInBlackBtn.ForeColor = System.Drawing.Color.White;
            this._removeInBlackBtn.Location = new System.Drawing.Point(10, 350);
            this._removeInBlackBtn.Name = "_removeInBlackBtn";
            this._removeInBlackBtn.Size = new System.Drawing.Size(180, 40);
            this._removeInBlackBtn.TabIndex = 0;
            this._removeInBlackBtn.Text = "REMOVE";
            this._removeInBlackBtn.UseVisualStyleBackColor = false;
            // 
            // _blackListBox
            // 
            this._blackListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(70)))));
            this._blackListBox.ForeColor = System.Drawing.Color.White;
            this._blackListBox.ItemHeight = 15;
            this._blackListBox.Location = new System.Drawing.Point(10, 22);
            this._blackListBox.Name = "_blackListBox";
            this._blackListBox.Size = new System.Drawing.Size(180, 244);
            this._blackListBox.TabIndex = 1;
            // 
            // _startBtn
            // 
            this._startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(78)))));
            this._startBtn.ForeColor = System.Drawing.Color.White;
            this._startBtn.Location = new System.Drawing.Point(128, 418);
            this._startBtn.Name = "_startBtn";
            this._startBtn.Size = new System.Drawing.Size(180, 40);
            this._startBtn.TabIndex = 1;
            this._startBtn.Text = "START";
            this._startBtn.UseVisualStyleBackColor = false;
            this._startBtn.Click += new System.EventHandler(this.StartBtn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(436, 500);
            this.Controls.Add(this._startBtn);
            this.Controls.Add(this._whiteGroupBox);
            this.Controls.Add(this._blackGroupBox);
            this.Name = "Form1";
            this.Text = "Startup White Black List";
            this._whiteGroupBox.ResumeLayout(false);
            this._whiteGroupBox.PerformLayout();
            this._blackGroupBox.ResumeLayout(false);
            this._blackGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox _whiteGroupBox;
        private GroupBox _blackGroupBox;
        private Button _addToWhiteBtn;
        private Button _addToBlackBtn;
        private Button _removeInWhiteBtn;
        private Button _removeInBlackBtn;
        private ListBox _whiteListBox;
        private ListBox _blackListBox;
        private TextBox _whiteTextBox;
        private TextBox _blackTextBox;
        private Button _startBtn;
    }
}
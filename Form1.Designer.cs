namespace ExSocket
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleGroupBox = new System.Windows.Forms.GroupBox();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.controlTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleGroupBox
            // 
            this.consoleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleGroupBox.Controls.Add(this.clientListBox);
            this.consoleGroupBox.Controls.Add(this.consoleTextBox);
            this.consoleGroupBox.Location = new System.Drawing.Point(10, 10);
            this.consoleGroupBox.Name = "consoleGroupBox";
            this.consoleGroupBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.consoleGroupBox.Size = new System.Drawing.Size(464, 161);
            this.consoleGroupBox.TabIndex = 1;
            this.consoleGroupBox.TabStop = false;
            this.consoleGroupBox.Text = "Console";
            // 
            // clientListBox
            // 
            this.clientListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 12;
            this.clientListBox.Location = new System.Drawing.Point(324, 17);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(137, 134);
            this.clientListBox.TabIndex = 2;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.consoleTextBox.Location = new System.Drawing.Point(9, 20);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.consoleTextBox.Size = new System.Drawing.Size(300, 131);
            this.consoleTextBox.TabIndex = 1;
            this.consoleTextBox.Text = "";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.enterButton);
            this.controlGroupBox.Controls.Add(this.controlTextBox);
            this.controlGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlGroupBox.Location = new System.Drawing.Point(10, 177);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.controlGroupBox.Size = new System.Drawing.Size(464, 47);
            this.controlGroupBox.TabIndex = 2;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // enterButton
            // 
            this.enterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.enterButton.Location = new System.Drawing.Point(373, 14);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(81, 28);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // controlTextBox
            // 
            this.controlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlTextBox.Location = new System.Drawing.Point(9, 17);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(358, 21);
            this.controlTextBox.TabIndex = 0;
            this.controlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlTextBox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.controlGroupBox);
            this.panel1.Controls.Add(this.consoleGroupBox);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(484, 234);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectMenuToolStripMenuItem
            // 
            this.connectMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1,
            this.disconnectToolStripMenuItem});
            this.connectMenuToolStripMenuItem.Name = "connectMenuToolStripMenuItem";
            this.connectMenuToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.connectMenuToolStripMenuItem.Text = "연결";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem1.Text = "Connect";
            this.connectToolStripMenuItem1.Click += new System.EventHandler(this.connectToolStripMenuItem1_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.consoleGroupBox.ResumeLayout(false);
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox consoleGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox controlTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    }
}


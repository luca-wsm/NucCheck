
namespace NucCheck
{
    partial class Panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.startBttn = new System.Windows.Forms.Button();
            this.targetWebsiteBox = new System.Windows.Forms.TextBox();
            this.checkerGroupBox = new System.Windows.Forms.GroupBox();
            this.seperatorLabel1 = new System.Windows.Forms.Label();
            this.threadDelayLabel = new System.Windows.Forms.Label();
            this.threadTimeOut = new System.Windows.Forms.NumericUpDown();
            this.stopBttn = new System.Windows.Forms.Button();
            this.searchStringBox = new System.Windows.Forms.TextBox();
            this.comparerBttn = new System.Windows.Forms.Button();
            this.notificationGroupBox = new System.Windows.Forms.GroupBox();
            this.seperatorLabel2 = new System.Windows.Forms.Label();
            this.emailSettingsBttn = new System.Windows.Forms.Button();
            this.hidePanelButton = new System.Windows.Forms.Button();
            this.notificationValueBox = new System.Windows.Forms.TextBox();
            this.notificationTypeBox = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.faceLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.LinkLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadTimeOut)).BeginInit();
            this.notificationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(6, 275);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(243, 35);
            this.startBttn.TabIndex = 0;
            this.startBttn.Text = "› Start";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
            // 
            // targetWebsiteBox
            // 
            this.targetWebsiteBox.Location = new System.Drawing.Point(6, 22);
            this.targetWebsiteBox.Name = "targetWebsiteBox";
            this.targetWebsiteBox.PlaceholderText = "Target Website";
            this.targetWebsiteBox.Size = new System.Drawing.Size(243, 23);
            this.targetWebsiteBox.TabIndex = 2;
            // 
            // checkerGroupBox
            // 
            this.checkerGroupBox.Controls.Add(this.seperatorLabel1);
            this.checkerGroupBox.Controls.Add(this.threadDelayLabel);
            this.checkerGroupBox.Controls.Add(this.threadTimeOut);
            this.checkerGroupBox.Controls.Add(this.stopBttn);
            this.checkerGroupBox.Controls.Add(this.searchStringBox);
            this.checkerGroupBox.Controls.Add(this.targetWebsiteBox);
            this.checkerGroupBox.Controls.Add(this.startBttn);
            this.checkerGroupBox.Location = new System.Drawing.Point(12, 15);
            this.checkerGroupBox.Name = "checkerGroupBox";
            this.checkerGroupBox.Size = new System.Drawing.Size(255, 320);
            this.checkerGroupBox.TabIndex = 3;
            this.checkerGroupBox.TabStop = false;
            this.checkerGroupBox.Text = "— Scraper —";
            // 
            // seperatorLabel1
            // 
            this.seperatorLabel1.AutoSize = true;
            this.seperatorLabel1.Location = new System.Drawing.Point(6, 177);
            this.seperatorLabel1.Name = "seperatorLabel1";
            this.seperatorLabel1.Size = new System.Drawing.Size(247, 15);
            this.seperatorLabel1.TabIndex = 5;
            this.seperatorLabel1.Text = "————————————————————";
            // 
            // threadDelayLabel
            // 
            this.threadDelayLabel.AutoSize = true;
            this.threadDelayLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threadDelayLabel.Location = new System.Drawing.Point(6, 106);
            this.threadDelayLabel.Name = "threadDelayLabel";
            this.threadDelayLabel.Size = new System.Drawing.Size(107, 19);
            this.threadDelayLabel.TabIndex = 4;
            this.threadDelayLabel.Text = "Thread Delay (s)";
            // 
            // threadTimeOut
            // 
            this.threadTimeOut.Location = new System.Drawing.Point(6, 128);
            this.threadTimeOut.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.threadTimeOut.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadTimeOut.Name = "threadTimeOut";
            this.threadTimeOut.Size = new System.Drawing.Size(243, 23);
            this.threadTimeOut.TabIndex = 4;
            this.threadTimeOut.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadTimeOut.ValueChanged += new System.EventHandler(this.threadTimeOut_ValueChanged);
            // 
            // stopBttn
            // 
            this.stopBttn.Enabled = false;
            this.stopBttn.Location = new System.Drawing.Point(6, 219);
            this.stopBttn.Name = "stopBttn";
            this.stopBttn.Size = new System.Drawing.Size(243, 34);
            this.stopBttn.TabIndex = 4;
            this.stopBttn.Text = "› Stop";
            this.stopBttn.UseVisualStyleBackColor = true;
            this.stopBttn.Click += new System.EventHandler(this.stopBttn_Click);
            // 
            // searchStringBox
            // 
            this.searchStringBox.Location = new System.Drawing.Point(6, 69);
            this.searchStringBox.Name = "searchStringBox";
            this.searchStringBox.PlaceholderText = "Search String";
            this.searchStringBox.Size = new System.Drawing.Size(243, 23);
            this.searchStringBox.TabIndex = 3;
            // 
            // comparerBttn
            // 
            this.comparerBttn.Location = new System.Drawing.Point(6, 219);
            this.comparerBttn.Name = "comparerBttn";
            this.comparerBttn.Size = new System.Drawing.Size(243, 34);
            this.comparerBttn.TabIndex = 5;
            this.comparerBttn.Text = "› Website Comparer";
            this.comparerBttn.UseVisualStyleBackColor = true;
            this.comparerBttn.Click += new System.EventHandler(this.comparerBttn_Click);
            // 
            // notificationGroupBox
            // 
            this.notificationGroupBox.Controls.Add(this.seperatorLabel2);
            this.notificationGroupBox.Controls.Add(this.emailSettingsBttn);
            this.notificationGroupBox.Controls.Add(this.hidePanelButton);
            this.notificationGroupBox.Controls.Add(this.comparerBttn);
            this.notificationGroupBox.Controls.Add(this.notificationValueBox);
            this.notificationGroupBox.Controls.Add(this.notificationTypeBox);
            this.notificationGroupBox.Location = new System.Drawing.Point(318, 15);
            this.notificationGroupBox.Name = "notificationGroupBox";
            this.notificationGroupBox.Size = new System.Drawing.Size(255, 320);
            this.notificationGroupBox.TabIndex = 4;
            this.notificationGroupBox.TabStop = false;
            this.notificationGroupBox.Text = "— Notifications / Settings —";
            // 
            // seperatorLabel2
            // 
            this.seperatorLabel2.AutoSize = true;
            this.seperatorLabel2.Location = new System.Drawing.Point(6, 177);
            this.seperatorLabel2.Name = "seperatorLabel2";
            this.seperatorLabel2.Size = new System.Drawing.Size(247, 15);
            this.seperatorLabel2.TabIndex = 6;
            this.seperatorLabel2.Text = "————————————————————";
            // 
            // emailSettingsBttn
            // 
            this.emailSettingsBttn.Location = new System.Drawing.Point(8, 120);
            this.emailSettingsBttn.Name = "emailSettingsBttn";
            this.emailSettingsBttn.Size = new System.Drawing.Size(242, 34);
            this.emailSettingsBttn.TabIndex = 3;
            this.emailSettingsBttn.Text = "Email Settings";
            this.emailSettingsBttn.UseVisualStyleBackColor = true;
            this.emailSettingsBttn.Click += new System.EventHandler(this.emailSettingsBttn_Click);
            // 
            // hidePanelButton
            // 
            this.hidePanelButton.Location = new System.Drawing.Point(6, 275);
            this.hidePanelButton.Name = "hidePanelButton";
            this.hidePanelButton.Size = new System.Drawing.Size(243, 34);
            this.hidePanelButton.TabIndex = 2;
            this.hidePanelButton.Text = "› Hide Panel";
            this.hidePanelButton.UseVisualStyleBackColor = true;
            this.hidePanelButton.Click += new System.EventHandler(this.hidePanelButton_Click);
            // 
            // notificationValueBox
            // 
            this.notificationValueBox.Enabled = false;
            this.notificationValueBox.Location = new System.Drawing.Point(6, 69);
            this.notificationValueBox.Name = "notificationValueBox";
            this.notificationValueBox.PlaceholderText = "Notification Value";
            this.notificationValueBox.Size = new System.Drawing.Size(243, 23);
            this.notificationValueBox.TabIndex = 1;
            // 
            // notificationTypeBox
            // 
            this.notificationTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notificationTypeBox.FormattingEnabled = true;
            this.notificationTypeBox.Items.AddRange(new object[] {
            "Send Email",
            "URL Call"});
            this.notificationTypeBox.Location = new System.Drawing.Point(6, 22);
            this.notificationTypeBox.Name = "notificationTypeBox";
            this.notificationTypeBox.Size = new System.Drawing.Size(244, 23);
            this.notificationTypeBox.TabIndex = 0;
            this.notificationTypeBox.SelectedIndexChanged += new System.EventHandler(this.notificationTypeBox_SelectedIndexChanged);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.Window;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Location = new System.Drawing.Point(12, 399);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(561, 227);
            this.logBox.TabIndex = 5;
            // 
            // faceLabel
            // 
            this.faceLabel.AutoSize = true;
            this.faceLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faceLabel.Location = new System.Drawing.Point(264, 351);
            this.faceLabel.Name = "faceLabel";
            this.faceLabel.Size = new System.Drawing.Size(58, 25);
            this.faceLabel.TabIndex = 6;
            this.faceLabel.Text = "( ͡° ͜ʖ ͡°)";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpLabel.Location = new System.Drawing.Point(273, 632);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(37, 19);
            this.helpLabel.TabIndex = 7;
            this.helpLabel.TabStop = true;
            this.helpLabel.Text = "Help";
            this.helpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLabel_LinkClicked);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "» NucCheck ";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 660);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.faceLabel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.notificationGroupBox);
            this.Controls.Add(this.checkerGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "» NucCheck ";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.checkerGroupBox.ResumeLayout(false);
            this.checkerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadTimeOut)).EndInit();
            this.notificationGroupBox.ResumeLayout(false);
            this.notificationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBttn;
        private System.Windows.Forms.TextBox targetWebsiteBox;
        private System.Windows.Forms.GroupBox checkerGroupBox;
        private System.Windows.Forms.Button stopBttn;
        private System.Windows.Forms.TextBox searchStringBox;
        private System.Windows.Forms.GroupBox notificationGroupBox;
        private System.Windows.Forms.Button emailSettingsBttn;
        private System.Windows.Forms.Button hidePanelButton;
        private System.Windows.Forms.TextBox notificationValueBox;
        private System.Windows.Forms.ComboBox notificationTypeBox;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button comparerBttn;
        private System.Windows.Forms.Label seperatorLabel1;
        private System.Windows.Forms.Label threadDelayLabel;
        private System.Windows.Forms.NumericUpDown threadTimeOut;
        private System.Windows.Forms.Label seperatorLabel2;
        private System.Windows.Forms.Label faceLabel;
        private System.Windows.Forms.LinkLabel helpLabel;
        public System.Windows.Forms.NotifyIcon notifyIcon;
    }
}



namespace NucCheck
{
    partial class ComparerPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparerPanel));
            this.targetWebsiteBox = new System.Windows.Forms.TextBox();
            this.threadDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.threadDelayLabel = new System.Windows.Forms.Label();
            this.notificationGroupBox = new System.Windows.Forms.GroupBox();
            this.emailSettingsBttn = new System.Windows.Forms.Button();
            this.hidePanelBttn = new System.Windows.Forms.Button();
            this.notificationValueBox = new System.Windows.Forms.TextBox();
            this.notificationTypeBox = new System.Windows.Forms.ComboBox();
            this.comparerGroupBox = new System.Windows.Forms.GroupBox();
            this.stopBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.threadDelayUpDown)).BeginInit();
            this.notificationGroupBox.SuspendLayout();
            this.comparerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetWebsiteBox
            // 
            this.targetWebsiteBox.Location = new System.Drawing.Point(6, 24);
            this.targetWebsiteBox.Name = "targetWebsiteBox";
            this.targetWebsiteBox.PlaceholderText = "Target Website";
            this.targetWebsiteBox.Size = new System.Drawing.Size(243, 23);
            this.targetWebsiteBox.TabIndex = 0;
            // 
            // threadDelayUpDown
            // 
            this.threadDelayUpDown.Location = new System.Drawing.Point(6, 72);
            this.threadDelayUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.threadDelayUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadDelayUpDown.Name = "threadDelayUpDown";
            this.threadDelayUpDown.Size = new System.Drawing.Size(243, 23);
            this.threadDelayUpDown.TabIndex = 1;
            this.threadDelayUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadDelayUpDown.ValueChanged += new System.EventHandler(this.threadDelayUpDown_ValueChanged);
            // 
            // threadDelayLabel
            // 
            this.threadDelayLabel.AutoSize = true;
            this.threadDelayLabel.Location = new System.Drawing.Point(6, 50);
            this.threadDelayLabel.Name = "threadDelayLabel";
            this.threadDelayLabel.Size = new System.Drawing.Size(91, 15);
            this.threadDelayLabel.TabIndex = 2;
            this.threadDelayLabel.Text = "Thread Delay (s)";
            // 
            // notificationGroupBox
            // 
            this.notificationGroupBox.Controls.Add(this.emailSettingsBttn);
            this.notificationGroupBox.Controls.Add(this.hidePanelBttn);
            this.notificationGroupBox.Controls.Add(this.notificationValueBox);
            this.notificationGroupBox.Controls.Add(this.notificationTypeBox);
            this.notificationGroupBox.Location = new System.Drawing.Point(301, 12);
            this.notificationGroupBox.Name = "notificationGroupBox";
            this.notificationGroupBox.Size = new System.Drawing.Size(256, 214);
            this.notificationGroupBox.TabIndex = 5;
            this.notificationGroupBox.TabStop = false;
            this.notificationGroupBox.Text = "— Notifications / Settings —";
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
            // hidePanelBttn
            // 
            this.hidePanelBttn.Location = new System.Drawing.Point(8, 166);
            this.hidePanelBttn.Name = "hidePanelBttn";
            this.hidePanelBttn.Size = new System.Drawing.Size(243, 34);
            this.hidePanelBttn.TabIndex = 2;
            this.hidePanelBttn.Text = "› Hide Panel";
            this.hidePanelBttn.UseVisualStyleBackColor = true;
            this.hidePanelBttn.Click += new System.EventHandler(this.hidePanelBttn_Click);
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
            // comparerGroupBox
            // 
            this.comparerGroupBox.Controls.Add(this.stopBttn);
            this.comparerGroupBox.Controls.Add(this.startBttn);
            this.comparerGroupBox.Controls.Add(this.targetWebsiteBox);
            this.comparerGroupBox.Controls.Add(this.threadDelayUpDown);
            this.comparerGroupBox.Controls.Add(this.threadDelayLabel);
            this.comparerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.comparerGroupBox.Name = "comparerGroupBox";
            this.comparerGroupBox.Size = new System.Drawing.Size(255, 214);
            this.comparerGroupBox.TabIndex = 6;
            this.comparerGroupBox.TabStop = false;
            this.comparerGroupBox.Text = "— Comparer —";
            // 
            // stopBttn
            // 
            this.stopBttn.Enabled = false;
            this.stopBttn.Location = new System.Drawing.Point(6, 120);
            this.stopBttn.Name = "stopBttn";
            this.stopBttn.Size = new System.Drawing.Size(243, 34);
            this.stopBttn.TabIndex = 4;
            this.stopBttn.Text = "› Stop";
            this.stopBttn.UseVisualStyleBackColor = true;
            this.stopBttn.Click += new System.EventHandler(this.stopBttn_Click);
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(6, 168);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(243, 34);
            this.startBttn.TabIndex = 3;
            this.startBttn.Text = "› Start";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.Window;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Location = new System.Drawing.Point(12, 248);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(545, 257);
            this.logBox.TabIndex = 7;
            // 
            // ComparerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 521);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.comparerGroupBox);
            this.Controls.Add(this.notificationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComparerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "» NucCheck | Comparer";
            ((System.ComponentModel.ISupportInitialize)(this.threadDelayUpDown)).EndInit();
            this.notificationGroupBox.ResumeLayout(false);
            this.notificationGroupBox.PerformLayout();
            this.comparerGroupBox.ResumeLayout(false);
            this.comparerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox targetWebsiteBox;
        private System.Windows.Forms.NumericUpDown threadDelayUpDown;
        private System.Windows.Forms.Label threadDelayLabel;
        private System.Windows.Forms.GroupBox notificationGroupBox;
        private System.Windows.Forms.Button emailSettingsBttn;
        private System.Windows.Forms.Button hidePanelBttn;
        private System.Windows.Forms.TextBox notificationValueBox;
        private System.Windows.Forms.ComboBox notificationTypeBox;
        private System.Windows.Forms.GroupBox comparerGroupBox;
        private System.Windows.Forms.Button stopBttn;
        private System.Windows.Forms.Button startBttn;
        private System.Windows.Forms.ListBox logBox;
    }
}
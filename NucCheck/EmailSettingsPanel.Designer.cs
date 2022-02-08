
namespace NucCheck
{
    partial class EmailSettingsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailSettingsPanel));
            this.smtpPasswordBox = new System.Windows.Forms.TextBox();
            this.testmailBttn = new System.Windows.Forms.Button();
            this.emailSubjectBox = new System.Windows.Forms.TextBox();
            this.targetEmailBox = new System.Windows.Forms.TextBox();
            this.smtpServerBox = new System.Windows.Forms.TextBox();
            this.emailContentBox = new System.Windows.Forms.TextBox();
            this.saveConfigurationBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.smtpEmailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.smtpPort = new System.Windows.Forms.NumericUpDown();
            this.deleteConfigurationBttn = new System.Windows.Forms.Button();
            this.informationLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // smtpPasswordBox
            // 
            this.smtpPasswordBox.Location = new System.Drawing.Point(194, 89);
            this.smtpPasswordBox.Name = "smtpPasswordBox";
            this.smtpPasswordBox.Size = new System.Drawing.Size(158, 23);
            this.smtpPasswordBox.TabIndex = 0;
            this.smtpPasswordBox.UseSystemPasswordChar = true;
            // 
            // testmailBttn
            // 
            this.testmailBttn.Location = new System.Drawing.Point(253, 379);
            this.testmailBttn.Name = "testmailBttn";
            this.testmailBttn.Size = new System.Drawing.Size(93, 34);
            this.testmailBttn.TabIndex = 1;
            this.testmailBttn.Text = "Test Email";
            this.testmailBttn.UseVisualStyleBackColor = true;
            this.testmailBttn.Click += new System.EventHandler(this.testmailBttn_Click);
            // 
            // emailSubjectBox
            // 
            this.emailSubjectBox.Location = new System.Drawing.Point(194, 151);
            this.emailSubjectBox.Name = "emailSubjectBox";
            this.emailSubjectBox.Size = new System.Drawing.Size(158, 23);
            this.emailSubjectBox.TabIndex = 4;
            // 
            // targetEmailBox
            // 
            this.targetEmailBox.Location = new System.Drawing.Point(9, 151);
            this.targetEmailBox.Name = "targetEmailBox";
            this.targetEmailBox.Size = new System.Drawing.Size(161, 23);
            this.targetEmailBox.TabIndex = 6;
            // 
            // smtpServerBox
            // 
            this.smtpServerBox.Location = new System.Drawing.Point(9, 34);
            this.smtpServerBox.Name = "smtpServerBox";
            this.smtpServerBox.Size = new System.Drawing.Size(158, 23);
            this.smtpServerBox.TabIndex = 7;
            // 
            // emailContentBox
            // 
            this.emailContentBox.Location = new System.Drawing.Point(13, 212);
            this.emailContentBox.Multiline = true;
            this.emailContentBox.Name = "emailContentBox";
            this.emailContentBox.Size = new System.Drawing.Size(333, 161);
            this.emailContentBox.TabIndex = 8;
            // 
            // saveConfigurationBttn
            // 
            this.saveConfigurationBttn.Location = new System.Drawing.Point(112, 379);
            this.saveConfigurationBttn.Name = "saveConfigurationBttn";
            this.saveConfigurationBttn.Size = new System.Drawing.Size(93, 34);
            this.saveConfigurationBttn.TabIndex = 9;
            this.saveConfigurationBttn.Text = "Save Config";
            this.saveConfigurationBttn.UseVisualStyleBackColor = true;
            this.saveConfigurationBttn.Click += new System.EventHandler(this.saveConfigurationBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "SMTP-Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "SMTP-Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "SMTP-Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Target-Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email-Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-Mail Content:";
            // 
            // smtpEmailBox
            // 
            this.smtpEmailBox.Location = new System.Drawing.Point(9, 89);
            this.smtpEmailBox.Name = "smtpEmailBox";
            this.smtpEmailBox.Size = new System.Drawing.Size(158, 23);
            this.smtpEmailBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "SMTP-Email";
            // 
            // smtpPort
            // 
            this.smtpPort.Location = new System.Drawing.Point(194, 34);
            this.smtpPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.smtpPort.Name = "smtpPort";
            this.smtpPort.Size = new System.Drawing.Size(158, 23);
            this.smtpPort.TabIndex = 20;
            this.smtpPort.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // deleteConfigurationBttn
            // 
            this.deleteConfigurationBttn.Location = new System.Drawing.Point(13, 379);
            this.deleteConfigurationBttn.Name = "deleteConfigurationBttn";
            this.deleteConfigurationBttn.Size = new System.Drawing.Size(93, 34);
            this.deleteConfigurationBttn.TabIndex = 21;
            this.deleteConfigurationBttn.Text = "Delete Config";
            this.deleteConfigurationBttn.UseVisualStyleBackColor = true;
            this.deleteConfigurationBttn.Click += new System.EventHandler(this.deleteConfigurationBttn_Click);
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(334, 194);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(12, 15);
            this.informationLabel.TabIndex = 22;
            this.informationLabel.TabStop = true;
            this.informationLabel.Text = "?";
            this.informationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.informationLabel_LinkClicked);
            // 
            // EmailSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 420);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.deleteConfigurationBttn);
            this.Controls.Add(this.smtpPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.smtpEmailBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveConfigurationBttn);
            this.Controls.Add(this.emailContentBox);
            this.Controls.Add(this.smtpServerBox);
            this.Controls.Add(this.targetEmailBox);
            this.Controls.Add(this.emailSubjectBox);
            this.Controls.Add(this.testmailBttn);
            this.Controls.Add(this.smtpPasswordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmailSettingsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "» NucCheck | Email Settings";
            this.Load += new System.EventHandler(this.EmailSettingsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smtpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox smtpPasswordBox;
        private System.Windows.Forms.Button testmailBttn;
        private System.Windows.Forms.TextBox emailSubjectBox;
        private System.Windows.Forms.TextBox targetEmailBox;
        private System.Windows.Forms.TextBox smtpServerBox;
        private System.Windows.Forms.TextBox emailContentBox;
        private System.Windows.Forms.Button saveConfigurationBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox smtpEmailBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown smtpPort;
        private System.Windows.Forms.Button deleteConfigurationBttn;
        private System.Windows.Forms.LinkLabel informationLabel;
    }
}
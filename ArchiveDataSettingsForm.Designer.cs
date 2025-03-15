namespace Kwerendy
{
    partial class ArchiveDataSettingsForm
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
            txtBoxCompanyName = new TextBox();
            label1 = new Label();
            txtBoxAddressLine1 = new TextBox();
            txtBoxAddressLine2 = new TextBox();
            txtBoxPhone = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxBankAccount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEditCompanyInfo = new Button();
            btnSave = new Button();
            label7 = new Label();
            txtBoxLeadTime = new TextBox();
            txtBoxEntryFee = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtBoxCompanyName
            // 
            txtBoxCompanyName.Enabled = false;
            txtBoxCompanyName.Location = new Point(289, 19);
            txtBoxCompanyName.Name = "txtBoxCompanyName";
            txtBoxCompanyName.Size = new Size(396, 27);
            txtBoxCompanyName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Nazwa archiwum";
            // 
            // txtBoxAddressLine1
            // 
            txtBoxAddressLine1.Enabled = false;
            txtBoxAddressLine1.Location = new Point(289, 52);
            txtBoxAddressLine1.Name = "txtBoxAddressLine1";
            txtBoxAddressLine1.Size = new Size(396, 27);
            txtBoxAddressLine1.TabIndex = 2;
            // 
            // txtBoxAddressLine2
            // 
            txtBoxAddressLine2.Enabled = false;
            txtBoxAddressLine2.Location = new Point(289, 85);
            txtBoxAddressLine2.Name = "txtBoxAddressLine2";
            txtBoxAddressLine2.Size = new Size(396, 27);
            txtBoxAddressLine2.TabIndex = 3;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Enabled = false;
            txtBoxPhone.Location = new Point(289, 118);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(396, 27);
            txtBoxPhone.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Enabled = false;
            txtBoxEmail.Location = new Point(289, 151);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(396, 27);
            txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxBankAccount
            // 
            txtBoxBankAccount.Enabled = false;
            txtBoxBankAccount.Location = new Point(289, 184);
            txtBoxBankAccount.Name = "txtBoxBankAccount";
            txtBoxBankAccount.Size = new Size(396, 27);
            txtBoxBankAccount.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 7;
            label2.Text = "Adres linia 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "Adres linia 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Nr telefonu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 11;
            label6.Text = "Nr konta bankowego";
            // 
            // btnEditCompanyInfo
            // 
            btnEditCompanyInfo.Location = new Point(26, 364);
            btnEditCompanyInfo.Name = "btnEditCompanyInfo";
            btnEditCompanyInfo.Size = new Size(94, 29);
            btnEditCompanyInfo.TabIndex = 12;
            btnEditCompanyInfo.Text = "Edytuj";
            btnEditCompanyInfo.UseVisualStyleBackColor = true;
            btnEditCompanyInfo.Click += btn_EditCompanyInfo_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(152, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 220);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 14;
            label7.Text = "Czas realizacji zgłoszenia";
            // 
            // txtBoxLeadTime
            // 
            txtBoxLeadTime.Enabled = false;
            txtBoxLeadTime.Location = new Point(289, 217);
            txtBoxLeadTime.Name = "txtBoxLeadTime";
            txtBoxLeadTime.Size = new Size(396, 27);
            txtBoxLeadTime.TabIndex = 15;
            // 
            // txtBoxEntryFee
            // 
            txtBoxEntryFee.Enabled = false;
            txtBoxEntryFee.Location = new Point(289, 250);
            txtBoxEntryFee.Name = "txtBoxEntryFee";
            txtBoxEntryFee.Size = new Size(396, 27);
            txtBoxEntryFee.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 253);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 17;
            label8.Text = "Cena kwerendy";
            // 
            // ArchiveDataSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtBoxEntryFee);
            Controls.Add(txtBoxLeadTime);
            Controls.Add(label7);
            Controls.Add(btnSave);
            Controls.Add(btnEditCompanyInfo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxBankAccount);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxAddressLine2);
            Controls.Add(txtBoxAddressLine1);
            Controls.Add(label1);
            Controls.Add(txtBoxCompanyName);
            Name = "ArchiveDataSettingsForm";
            Text = "ArchiveDataSettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxCompanyName;
        private Label label1;
        private TextBox txtBoxAddressLine1;
        private TextBox txtBoxAddressLine2;
        private TextBox txtBoxPhone;
        private TextBox txtBoxEmail;
        private TextBox txtBoxBankAccount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEditCompanyInfo;
        private Button btnSave;
        private Label label7;
        private TextBox txtBoxLeadTime;
        private TextBox txtBoxEntryFee;
        private Label label8;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwerendy
{
    public partial class ArchiveDataSettingsForm : Form
    {
        private List<TextBox> companyInfoTextBoxes = new List<TextBox>();

        private static void TextBoxesOnOff(List<TextBox> textBoxes, bool valueToSet)
        {
            foreach (var textBox in textBoxes)
                textBox.Enabled = valueToSet;
        }

        public ArchiveDataSettingsForm()
        {
            InitializeComponent();

            companyInfoTextBoxes.Add(txtBoxCompanyName);
            companyInfoTextBoxes.Add(txtBoxAddressLine1);
            companyInfoTextBoxes.Add(txtBoxAddressLine2);
            companyInfoTextBoxes.Add(txtBoxPhone);
            companyInfoTextBoxes.Add(txtBoxEmail);
            companyInfoTextBoxes.Add(txtBoxBankAccount);
            companyInfoTextBoxes.Add(txtBoxLeadTime);
            companyInfoTextBoxes.Add(txtBoxEntryFee);

            txtBoxCompanyName.Text = Properties.Settings.Default.CompanyName;
            txtBoxAddressLine1.Text = Properties.Settings.Default.AddressLine1;
            txtBoxAddressLine2.Text = Properties.Settings.Default.AddressLine2;
            txtBoxPhone.Text = Properties.Settings.Default.CompanyPhoneNumber;
            txtBoxEmail.Text = Properties.Settings.Default.CompanyEmailAddress;
            txtBoxBankAccount.Text = Properties.Settings.Default.CompanyBankAccount;
            txtBoxLeadTime.Text = Properties.Settings.Default.LeadTime;
            txtBoxEntryFee.Text = Properties.Settings.Default.EntryFee;

            Properties.Settings.Default.Save();
        }

        private void btn_EditCompanyInfo_Click(object sender, EventArgs e)
        {
            TextBoxesOnOff(companyInfoTextBoxes, true);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CompanyName = txtBoxCompanyName.Text;
            Properties.Settings.Default.AddressLine1 = txtBoxAddressLine1.Text;
            Properties.Settings.Default.AddressLine2 = txtBoxAddressLine2.Text;
            Properties.Settings.Default.CompanyPhoneNumber = txtBoxPhone.Text;
            Properties.Settings.Default.CompanyEmailAddress = txtBoxEmail.Text;
            Properties.Settings.Default.CompanyBankAccount = txtBoxBankAccount.Text;
            Properties.Settings.Default.LeadTime = txtBoxLeadTime.Text;
            Properties.Settings.Default.EntryFee = txtBoxEntryFee.Text;

            Properties.Settings.Default.Save();

            TextBoxesOnOff(companyInfoTextBoxes, false);

            btnSave.Enabled = false;
            btnEditCompanyInfo.Enabled = true;
        }
    }
}

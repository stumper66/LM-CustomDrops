using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_CustomDrops
{
    public partial class RenameForm : Form
    {
        public RenameForm(string Name, Mainform mainform)
        {
            InitializeComponent();
            m_Name = Name;
            m_MainForm = mainform;
        }

        private Mainform m_MainForm;
        private string m_Name;

        private void RenameForm_Load(object sender, EventArgs e)
        {
            txtName.Text = m_Name;
            txtName.SelectAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (m_MainForm.IsMobOrGroupNameInUse(txtName.Text.Trim()))
            {
                MessageBox.Show("That mob or group name is already in use!");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = txtName.Text.Length > 0 && !string.Equals(txtName.Text, m_Name);
        }

        public string RenamedName
        {
            get { return txtName.Text; }
        }
    }
}

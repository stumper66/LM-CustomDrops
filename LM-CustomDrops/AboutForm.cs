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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            const string Website = "https://www.spigotmc.org/resources/levelledmobs-for-1-14-x-1-16-x.74304/";
            System.Diagnostics.Process.Start(Website);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

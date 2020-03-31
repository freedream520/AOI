using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOI
{
    public partial class AOI : Form
    {
        public AOI()
        {
            InitializeComponent();
        }

        private void btnBrowseOrigin_Click(object sender, EventArgs e)
        {
            if (originFolderBrowser.ShowDialog() == DialogResult.OK)
                txtOriginFolder.Text = originFolderBrowser.SelectedPath;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.IO;

namespace AOI
{
    public partial class userCompareForm : MaterialForm
    {
        MaterialSkinManager msm = MaterialSkinManager.Instance;

        public int im_number;
        public mainForm parent;

        public userCompareForm()
        {
            InitializeComponent();
        }

        private void userCompareForm_Load(object sender, EventArgs e)
        {
            msm.AddFormToManage(this);

            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(
                Primary.Green800,
                Primary.Green900,
                Primary.Green500,
                Accent.LightBlue200,
                TextShade.WHITE);

            string user_decision_file_path = parent.txtTestFolder.Text + "/Result/user-actions/" + im_number.ToString() + "-ud.txt";
            StreamReader sr = new StreamReader(user_decision_file_path);
            if (sr.ReadLine() == "undecidable")
                btnIgnore.Enabled = false;
            sr.Close();
        }

        private void BtnIgnore_Click(object sender, EventArgs e)
        {
            Patch p = mainForm.patches.Find(t => t.im_number == im_number);
            Button btnTemp = (Button)parent.tableLayoutPanel1.GetControlFromPosition(p.col, p.row);
            btnTemp.FlatAppearance.BorderColor = Color.Yellow;

            string user_decision_file_path = parent.txtTestFolder.Text + "/Result/user-actions/" + im_number.ToString() + "-ud.txt";
            StreamWriter sw = new StreamWriter(user_decision_file_path, false);
            sw.WriteLine("ignore");
            sw.Flush();
            sw.Close();

            //File.Copy(parent.txtOriginFolder.Text + "\\" + im_number + ".bmp", parent.txtTestFolder.Text + "\\Result\\" + im_number + ".bmp", true);
            this.Close();
        }

        private void BtnKeep_Click(object sender, EventArgs e)
        {
            Patch p = mainForm.patches.Find(t => t.im_number == im_number);
            Button btnTemp = (Button)parent.tableLayoutPanel1.GetControlFromPosition(p.col, p.row);
            if (btnTemp.FlatAppearance.BorderColor == Color.SpringGreen)
            {
                this.Close();
                return;
            }
            if (btnTemp.FlatAppearance.BorderColor == Color.Yellow)
                btnTemp.FlatAppearance.BorderColor = Color.Red;

            string user_decision_file_path = parent.txtTestFolder.Text + "/Result/user-actions/" + im_number.ToString() + "-ud.txt";
            StreamWriter sw = new StreamWriter(user_decision_file_path, false);
            sw.WriteLine("keep");
            sw.Flush();
            sw.Close();

            this.Close();
        }

        private void userCompareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pictureBox1.Image.Dispose();
            this.pictureBox2.Image.Dispose();
            this.Dispose();
        }
    }
}

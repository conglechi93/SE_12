using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkAccount())
            {
                //Bill f = new Bill();
                FormManager f = new FormManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?",
                "Thông báo",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private bool checkAccount()
        {
            return true;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MousClick(object sender, MouseEventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Text = "";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}


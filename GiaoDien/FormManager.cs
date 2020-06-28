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
    public partial class FormManager : Form
    {
        private Form currentChildForm;
        public FormManager()
        {
            InitializeComponent();
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void MenuClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lbTieuDe.Text = btn.Text;
            foreach (Control item in pnl_ButtonMenu.Controls)
            {
                // item.BackColor = pnl_ButtonMenu.BackColor;
                item.BackColor = Color.Gray;
            }
            btn.BackColor = Color.CadetBlue;
            if (btn.Tag.ToString() == "1")
            {
                OpenChildForm(new Main());
            }
            if (btn.Tag.ToString() == "2")
            {
                OpenChildForm(new QL_Items());
            }
            if (btn.Tag.ToString() == "3")
            {
                OpenChildForm(new QL_User());
            }
            if (btn.Tag.ToString() == "4")
            {
                OpenChildForm(new QuanLyBill());
            }
            if (btn.Tag.ToString() == "5")
            {
                OpenChildForm(new CheckPoint());
            }
            if (btn.Tag.ToString() == "6")
            {
                OpenChildForm(new FB_Manager());
            }
            if (btn.Tag.ToString() == "7")
            {
                OpenChildForm(new Account_Manager());
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

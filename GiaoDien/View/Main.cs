﻿using GiaoDien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.View
{
    public partial class Main : Form
    {
        private string ID_User;
        private int total = 0;
        private List<List<Button>> matrix;
        private List<data_Order> tb_Order;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        internal List<data_Order> Tb_Order { get => tb_Order; set => tb_Order = value; }

        public Main(string id_user)
        {
            this.ID_User = id_user;
            tb_Order = new List<data_Order>();
            InitializeComponent();
            //setColumn_DGV();
            setCbb_Ctg();
            LoadMatrix();
            cbb_Ctg.SelectedIndex = 0;
        }

        //public void LoadMatrix(int cbb_index)
        public void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            //int dem = 0;
            //int value;
            //if(cbb_index == 0)
            //{
            //    value = BLL.QL_Items_BLL.Instance.CountItems_byIDCtg_BLL(0);
            //}    
            //else
            //{
            //    value = BLL.QL_Items_BLL.Instance.CountItems_byIDCtg_BLL(cbb_index);
            //}    
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < 4; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 4; j++)
                {
                    //if (dem == value) break;
                    //else dem++;
                    Button btn = new Button() { Width = 80, Height = 40 };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    pnlShow.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    btn.Click += btn_Click;
                    oldBtn = btn;
                }

                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
        }

        public void setName_btn(int cbb_index)
        {
            ClearMatrix();
            int index = 0;
            List<Item> item = BLL.QL_Items_BLL.Instance.getItems_byIDCtg_BLL(cbb_index);
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    if (item.Count != index)
                    {
                        Button btn = Matrix[i][j];
                        btn.Text = item[index].Items_Name;
                        btn.Tag = item[index].ID_Items;
                        index++;
                    }
                    else break;
                }
            }
        }

        public void setColumn_DGV()
        {
            DGV_Show.ColumnCount = 4;
            DGV_Show.Columns[0].Name = "Mã sản phẩm";
            DGV_Show.Columns[1].Name = "Tên sản phẩm";
            DGV_Show.Columns[2].Name = "Số lượng";
            DGV_Show.Columns[3].Name = "Đơn giá";

        }

        public void setCbb_Ctg()
        {
            if (cbb_Ctg.Items != null)
            {
                cbb_Ctg.Items.Clear();
            }
            cbb_Ctg.Items.Add(new CBBCtg { Text = "All", Values = 0 });
            foreach (Category i in BLL.QL_Items_BLL.Instance.getCtg_BLL())
            {
                cbb_Ctg.Items.Add(new CBBCtg
                {
                    Text = i.Category_Name,
                    Values = Convert.ToInt32(i.ID_Category)
                });
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "")
            {
                string id_item = btn.Tag.ToString();
                ShowOrder(id_item);
            }
        }

        private void ShowOrder(string id_item)
        {
            DGV_Show.DataSource = null;
            Item item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(id_item);
            bool check = true;
            foreach (data_Order i in tb_Order)
            {
                if (i.Items_ID == id_item)
                {
                    i.Values++;
                    check = false;
                    break;
                }
            }
            if (check) tb_Order.Add(new data_Order { Items_ID = item.ID_Items, Items_Name = item.Items_Name, Price = item.Price, Values = 1 });
            DGV_Show.DataSource = tb_Order;
        }
        private void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                }
            }
        }
        private void cbb_Ctg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbb_index = ((CBBCtg)cbb_Ctg.SelectedItem).Values;
            string cbb_string = cbb_Ctg.SelectedItem.ToString();
            setName_btn(cbb_index);
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DGV_Show.DataSource = null;
        }

        private void btn_TamTinh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in DGV_Show.Rows)
            {
                int price = Convert.ToInt32(i.Cells["Price"].Value.ToString());
                int value = Convert.ToInt32(i.Cells["Values"].Value.ToString());
                total += price * value;
            }
            txt_Total.Text = total.ToString();
        }

        private void btn_CreateBill_Click(object sender, EventArgs e)
        {
            Bill f = new Bill(ID_User, total, tb_Order);
            f.ShowDialog();
        }
    }
}

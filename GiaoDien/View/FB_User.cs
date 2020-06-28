using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.View
{
    public partial class FB_User : Form
    {
        public FB_User()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

        }
        private void WriteFile()
        {
            Console.WriteLine("Ban thich ghi gi trong Text???");
            String dulieunhap = Console.ReadLine();
            String filepath = "E:\\test.txt";// đường dẫn của file muốn tạo
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine("Cộng đồng Arduino VN");
            sWriter.WriteLine(dulieunhap);
            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
        }
    }
}

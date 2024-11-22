using QuanLyKhoHang.KhoHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renderDGV(DataGridView dgv, List<HangHoa> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        DanhSachHangHoa dsHH = new DanhSachHangHoa();

        private void adminBtnKhoHang_Click(object sender, EventArgs e)
        {


            HangHoa tmp1 = new HangHoa("Dell01", "", 10, 10000, 200000);
            HangHoa tmp2 = new HangHoa("Dell01", "", 10, 10000, 200000);
            dsHH.themHangHoa(tmp1);
            dsHH.themHangHoa(tmp2);

        }



        private void adminBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminBtnNhapHang_Click(object sender, EventArgs e)
        {
            QuanLy kh = new QuanLy();
            kh.ShowDialog();
        }
    }
}

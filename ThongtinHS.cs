using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLhocsinhgiaovien.Model;

namespace QLhocsinhgiaovien
{
    public partial class ThongtinHS : DevExpress.XtraEditors.XtraForm
    {
        public ThongtinHS()
        {
            InitializeComponent();
        }
        string mahs;
        int i = 0;
        public string laymahs
        {
            set { mahs = value; }
        }
        void hienthidanhsachhocsinh()
        {
            dgvhs.DataSource = new Hocsinhmod().dshs(mahs.Trim());
            dgvhs.BorderStyle = BorderStyle.Fixed3D;
            dgvhs.RowHeadersVisible = false;
        }
        private void ThongtinHS_Load(object sender, EventArgs e)
        {
            hienthidanhsachhocsinh();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int i = 0;
        }
        void BindingHS()
        {
            txtmaHS.DataBindings.Clear();
            txtmaHS.DataBindings.Add("text", dgvhs.DataSource, "MaHS");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", dgvhs.DataSource, "Hoten");
            cmbGioitinh.DataBindings.Clear();
            cmbGioitinh.DataBindings.Add("text", dgvhs.DataSource, "Gioitinh");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("text", dgvhs.DataSource, "Ngaysinh");
            cmbdiachi.DataBindings.Clear();
            cmbdiachi.DataBindings.Add("text", dgvhs.DataSource, "Diachi");
            cmbMaLop.DataBindings.Clear();
            cmbMaLop.DataBindings.Add("text", dgvhs.DataSource, "Malop");
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string _MaHS = "";
            try
            {
                _MaHS = txtmaHS.Text;
            }
            catch { }
            string _Hoten = "";
            try
            {
                _Hoten = txtHoten.Text;
            }
            catch { }
            DateTime _Ngaysinh = dtpNgaySinh.Value;
            string _Gioitinh = "";
            try
            {
                _Gioitinh = cmbGioitinh.Text;
            }
            catch { }
            string _Diachi = "";
            try
            {
                _Diachi = cmbdiachi.Text;
            }
            catch { }
            string _Malop = "";
            try
            {
                _Malop = cmbMaLop.Text;
            }
            catch { }
            int i = 0;
            i = controller.hocsinhcontroller.Updatehocsinh(_MaHS, _Hoten, _Ngaysinh, _Gioitinh, _Diachi, _Malop);
            if (i > 0)
            {
                MessageBox.Show("sửa thành công ");
                hienthidanhsachhocsinh();
                ThongtinHS_Load(sender, e);
            }
            else
            {
                MessageBox.Show("sửa KHÔNG thành công ");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            ThongtinHS_Load(sender, e);
        }

        private void dgvhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingHS();
        }

        private void btnXemlop_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.ShowDialog();
        }
    }
}
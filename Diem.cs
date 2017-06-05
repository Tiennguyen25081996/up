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
    public partial class Diem : DevExpress.XtraEditors.XtraForm
    {
        public Diem()
        {
            InitializeComponent();
        }
        int i = 0;
        void loadcontrolMaMon()
        {
            cmbmamon.DataSource = new Diemmod().DSMAMON();
            cmbmamon.DisplayMember = "MaMon";
            cmbmamon.ValueMember = "MaMon";
        }
        void loadcontrolMAHS()
        {
            cmbMahs.DataSource = new Hocsinhmod().dshocsinh();
            cmbMahs.DisplayMember = "MaHS";
            cmbMahs.ValueMember = "MaHS";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            enable(false);
            txttenhs.Enabled = false;
            txtiddiem.Enabled = false;
            txtdiemtb.Text = "";
            txtiddiem.Text = "";
            cmbMahs.Text = "";
            txttenhs.Text = "";
            cmbmamon.Text = "";
            i = 1;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtiddiem.Text.Trim()!="")
            {
                enable(false);
                i = 2;
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn GÌ");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (!txtiddiem.Text.Trim().Equals(""))
            {
                //  enable(false);
                try
                {
                    DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Diemmod.deletediem(int.Parse(txtiddiem.Text));
                        MessageBox.Show("Xóa Thành Công");
                        Diem_Load(sender, e);
                    }

                }
                catch
                {
                    MessageBox.Show("Mã điểm Không Hợp Lệ");
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Gì");
            }
            i = 0;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                //them
                Diemmod.insertdiem(cmbMahs.Text,float.Parse(txtdiemtb.Text),cmbmamon.Text);
                MessageBox.Show("Thêm Mới Thành Công");
            }
            if (i == 2)
            {
                //sua
                Diemmod.updatediem(int.Parse(txtiddiem.Text), cmbMahs.Text, float.Parse(txtdiemtb.Text), cmbmamon.Text);
                MessageBox.Show("Sửa Thành Công");
            }
            Diem_Load(sender, e);
        }
        private void enable(bool t)
        {
            btnthem.Enabled = t;
            btnsua.Enabled = t;
            btnxoa.Enabled = t;
            btnluu.Enabled = !t;
            btnhuy.Enabled = !t;
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable(true);
        }
        void bingding()
        {
            txtiddiem.DataBindings.Clear();
            txtiddiem.DataBindings.Add("text", Dgvdiem.DataSource, "IdDiem");
            cmbMahs.DataBindings.Clear();
            cmbMahs.DataBindings.Add("text", Dgvdiem.DataSource, "MaHS");
            txttenhs.DataBindings.Clear();
            txttenhs.DataBindings.Add("text", Dgvdiem.DataSource, "HoTen");
            txtdiemtb.DataBindings.Clear();
            txtdiemtb.DataBindings.Add("text", Dgvdiem.DataSource, "DiemTB");
            cmbmamon.DataBindings.Clear();
            cmbmamon.DataBindings.Add("text", Dgvdiem.DataSource, "MaMon");
        }
        private void Diem_Load(object sender, EventArgs e)
        {
            loadcontrolMaMon();
            loadcontrolMAHS();
            Dgvdiem.DataSource = new Diemmod().danhsachdiem();
            enable(true);

        }

        private void Dgvdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bingding();
        }

        private void btnxemmon_Click(object sender, EventArgs e)
        {
            MonHoc m = new MonHoc();
            m.ShowDialog();
        }

        private void cmbMahs_TextChanged(object sender, EventArgs e)
        {
            if (cmbMahs.Text !="System.Data.DataRowView"&&cmbMahs.Text !="")
            {
                var a = new Hocsinhmod().dshs(cmbMahs.Text);
                txttenhs.Text = a.Rows[0].ItemArray[1].ToString();
            }
            
        }
    }
}
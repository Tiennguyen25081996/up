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
    public partial class CapnhatdiemHS : DevExpress.XtraEditors.XtraForm
    {
        public CapnhatdiemHS()
        {
            InitializeComponent();
        }
        int i = 0;
        public string laymahs
        {
            set { txtmahs.Text = value; }
        }
        void hienthi()
        {
            Dgvdiemcapnhat.DataSource = new Diemmod().danhsachdiembymahs(txtmahs.Text.Trim());
        }
        void bingding()
        {
            txtiddiem.DataBindings.Clear();
            txtiddiem.DataBindings.Add("text", Dgvdiemcapnhat.DataSource, "IdDiem");
            txtmahs.DataBindings.Clear();
            txtmahs.DataBindings.Add("text", Dgvdiemcapnhat.DataSource, "MaHS");
            txttenhs.DataBindings.Clear();
            txttenhs.DataBindings.Add("text", Dgvdiemcapnhat.DataSource, "HoTen");
            txtdiemtb.DataBindings.Clear();
            txtdiemtb.DataBindings.Add("text", Dgvdiemcapnhat.DataSource, "DiemTB");
            cmbmamon.DataBindings.Clear();
            cmbmamon.DataBindings.Add("text", Dgvdiemcapnhat.DataSource, "MaMon");
        }
        private void CapnhatdiemHS_Load(object sender, EventArgs e)
        {
            hienthi();
            loadcontrolMaMon();
            txttenhs.Enabled = false;
            txtiddiem.Enabled = false;
        }
        void loadcontrolMaMon()
        {
            cmbmamon.DataSource = new Diemmod().DSMAMONchuadangky(txtmahs.Text);
            cmbmamon.DisplayMember = "MaMon";
            cmbmamon.ValueMember = "MaMon";
        }
        private void Dgvdiemcapnhat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bingding();
        }

        private void btnxemmon_Click(object sender, EventArgs e)
        {
            MonHoc m = new MonHoc();
            m.ShowDialog();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            enable(false);
            txttenhs.Enabled = false;
            txtiddiem.Enabled = false;
            txtdiemtb.Text = "";
            txtiddiem.Text = "";
            cmbmamon.Text = "";
            i = 1;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtiddiem.Text.Trim() != "")
            {
                enable(false);
                i = 2;
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn GÌ");
            }
        }
        private void enable(bool t)
        {
            btnthem.Enabled = t;
            btnsua.Enabled = t;
            btnxoa.Enabled = t;
            btnluu.Enabled = !t;
            btnhuy.Enabled = !t;
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
                        CapnhatdiemHS_Load(sender, e);
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
                Diemmod.insertdiem(txtmahs.Text, float.Parse(txtdiemtb.Text), cmbmamon.Text);
                MessageBox.Show("Thêm Mới Thành Công");
            }
            if (i == 2)
            {
                //sua
                Diemmod.updatediem(int.Parse(txtiddiem.Text), txtmahs.Text, float.Parse(txtdiemtb.Text), cmbmamon.Text);
                MessageBox.Show("Sửa Thành Công");
            }
            CapnhatdiemHS_Load(sender, e);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable(true);
            CapnhatdiemHS_Load(sender, e);
        }

        private void txtmahs_TextChanged(object sender, EventArgs e)
        {
            if (txtmahs.Text != "System.Data.DataRowView" && txtmahs.Text != "")
            {
                var a = new Hocsinhmod().dshs(txtmahs.Text);
                txttenhs.Text = a.Rows[0].ItemArray[1].ToString();
            }
        }
    }
}
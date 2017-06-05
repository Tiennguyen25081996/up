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
    public partial class MonHoc : DevExpress.XtraEditors.XtraForm
    {
        public MonHoc()
        {
            InitializeComponent();
        }
        int i = 0;
        void bingding()
        {
            txtMaMon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("text", dgvbangmon.DataSource, "MaMon");
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("text", dgvbangmon.DataSource, "TenMonHoc");         
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            dgvbangmon.DataSource = new Diemmod().DSMAMON();
        }
        private void enable(bool t)
        {
            btnthem.Enabled = t;
            btnsua.Enabled = t;
            btnxoa.Enabled = t;
            btnluu.Enabled = !t;
            btnhuy.Enabled = !t;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            enable(false);
            txtMaMon.Enabled = false;
            labe.Text = "";
            i = 1;
            if (dgvbangmon.RowCount < 10)
            {
                txtMaMon.Text = "Mon0" + (int.Parse(dgvbangmon.Rows[dgvbangmon.RowCount - 2].Cells["MaMon"].Value.ToString().Trim().Split('0')[1]) + 1).ToString().Trim();
            }
            else
            {
                txtMaMon.Text = "Mon" + (int.Parse(dgvbangmon.Rows[dgvbangmon.RowCount - 2].Cells["MaMon"].Value.ToString().Trim().Split('n')[1]) + 1).ToString().Trim();
            }
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Trim() != "")
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
            if (!txtMaMon.Text.Trim().Equals(""))
            {
                //  enable(false);
                try
                {
                    DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MonHocMod.deleteMon(txtMaMon.Text);
                        MessageBox.Show("Xóa Thành Công");
                        MonHoc_Load(sender, e);
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
                MonHocMod.insertMon(txtMaMon.Text.Trim(), txtTenMon.Text.Trim());
                MessageBox.Show("Thêm Mới Thành Công");
            }
            if (i == 2)
            {
                //sua
                MonHocMod.updateMon(txtMaMon.Text, txtTenMon.Text.Trim());
                MessageBox.Show("Sửa Thành Công");
            }
            MonHoc_Load(sender, e);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable(true);
            MonHoc_Load(sender, e);
        }

        private void dgvbangmon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bingding();
        }
    }
}
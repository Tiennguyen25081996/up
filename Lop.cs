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
using QLhocsinhgiaovien.views;

namespace QLhocsinhgiaovien
{
    public partial class Lop : DevExpress.XtraEditors.XtraForm
    {
        public Lop()
        {
            InitializeComponent();
        }
        int plag = 0;
        public void hienthidanhsachlop()
        {
            // tro toi data     
            dgvlop.DataSource = Model.lopmod.filldatasetlop().Tables[0];
            dgvlop.BorderStyle = BorderStyle.Fixed3D;
            dgvlop.RowHeadersVisible = false;

        }
        void Bindinglop()
        {
            txtLop.DataBindings.Clear();
            txtLop.DataBindings.Add("text", dgvlop.DataSource, "Malop");
            txtTenlop.DataBindings.Clear();
            txtTenlop.DataBindings.Add("text", dgvlop.DataSource, "Tenlop");
            cmbMagv.DataBindings.Clear();
            cmbMagv.DataBindings.Add("text", dgvlop.DataSource, "Magiaovien");
            txtsoluong.DataBindings.Clear();
            txtsoluong.DataBindings.Add("text", dgvlop.DataSource, "SoLuong");         
        }
        void dis_end(bool e)
        {
            btnhuy.Enabled = e;
            btnluu.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;

        }
        private void Lop_Load(object sender, EventArgs e)
        {
            hienthidanhsachlop();
            loadcontrolMaGV();
            Bindinglop();
            dis_end(false);
            txtsoluong.Enabled = false;
        }
        void cleardata()
        {
            txtLop.Text = "";
            txtTenlop.Text = "";
            cmbMagv.Text = "";
            txtsoluong.Text = "";          
        }


        private void btnXemgv_Click(object sender, EventArgs e)
        {
            dsgiaovien gv = new dsgiaovien();
            gv.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 0;
            cleardata();          
            dis_end(true);
            txtsoluong.Enabled = false;
            txtLop.Enabled = false;
            if(dgvlop.RowCount<= 11)
            {
                txtLop.Text = "Lop0" + (int.Parse(dgvlop.Rows[dgvlop.RowCount - 2].Cells["Malop"].Value.ToString().Trim().Split('0')[1]) + 1).ToString().Trim();
            }
            else
            {
                txtLop.Text = "Lop" + (int.Parse(dgvlop.Rows[dgvlop.RowCount - 2].Cells["Malop"].Value.ToString().Trim().Split('p')[1]) + 1).ToString().Trim();
            }
          
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            plag = 1;
            dis_end(true);
            txtsoluong.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            dis_end(true);
            txtsoluong.Enabled = false;
            string _Malop = "";
            try
            {
                _Malop = txtLop.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa???", "xác nhận !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = controller.Lopcontroller.Deletelop(_Malop);
                if (i > 0)
                {
                    MessageBox.Show("xóa thành công !!!");
                    hienthidanhsachlop();
                    Lop_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("xóa không thành công !!!");
                }
            }
            else
                return;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string _Malop = "";
            try
            {
                _Malop = txtLop.Text;
            }
            catch { }
            string _Tenlop = "";
            try
            {
                _Tenlop = txtTenlop.Text;
            }
            catch { }
            string _Magiaovien = "";
            try
            {
                _Magiaovien = cmbMagv.Text;
            }
            catch { }
            int _SoLuong = int.Parse(txtsoluong.Text);
            if (plag == 0)
            {
                //them moi 

                if (_Malop == "" || _Tenlop == "")
                {
                    MessageBox.Show("hãy điền đầy đủ thông tin !!!");
                }
                else
                {
                    int i = 0;
                    i = controller.Lopcontroller.Insearchlop(_Malop, _Tenlop, _Magiaovien);
                    if (i > 0)
                    {
                        MessageBox.Show("thêm mới thành công ");
                        hienthidanhsachlop();
                    }
                    else
                    {
                        MessageBox.Show("thêm mới KHÔNG thành công !!! bạn phải ghi rõ chức vụ ");
                    }
                }
            }
            else
            {   //sua
                int i = 0;
                i = controller.Lopcontroller.Updatelop(_Malop, _Tenlop, _Magiaovien);
                if (i > 0)
                {
                    MessageBox.Show("sửa thành công ");
                    hienthidanhsachlop();
                    Lop_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("sửa KHÔNG thành công ");
                }
            }
        }
        void loadcontrolMaGV()
        {
            cmbMagv.DataSource = Model.Giaovienmod.FillDataSet_spgetMaGV().Tables[0];
            cmbMagv.DisplayMember = "Magiaovien";
            cmbMagv.ValueMember = "Magiaovien";
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Lop_Load(sender, e);
            dis_end(false);
        }
    }
}
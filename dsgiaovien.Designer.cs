namespace QLhocsinhgiaovien
{
    partial class dsgiaovien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvdsgv = new System.Windows.Forms.DataGridView();
            this.Magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocHam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdsgv
            // 
            this.dgvdsgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Magiaovien,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.QueQuan,
            this.HocHam,
            this.sdt,
            this.MaCV,
            this.TinhTrang,
            this.MaMon});
            this.dgvdsgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdsgv.Location = new System.Drawing.Point(0, 87);
            this.dgvdsgv.Name = "dgvdsgv";
            this.dgvdsgv.Size = new System.Drawing.Size(943, 201);
            this.dgvdsgv.TabIndex = 0;
            // 
            // Magiaovien
            // 
            this.Magiaovien.DataPropertyName = "Magiaovien";
            this.Magiaovien.HeaderText = "Mã Giáo Viên";
            this.Magiaovien.Name = "Magiaovien";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "Quequan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            // 
            // HocHam
            // 
            this.HocHam.DataPropertyName = "Hocham";
            this.HocHam.HeaderText = "Học Hàm";
            this.HocHam.Name = "HocHam";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.Name = "sdt";
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "Tinhtrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.Name = "MaMon";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(427, 61);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(168, 20);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Sách Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm Kiếm Theo Tên";
            // 
            // dsgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvdsgv);
            this.Name = "dsgiaovien";
            this.Text = "Danh Sách Giáo Viên";
            this.Load += new System.EventHandler(this.dsgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsgv;
        private DevExpress.XtraEditors.TextEdit txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
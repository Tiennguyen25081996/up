namespace QLhocsinhgiaovien
{
    partial class CapnhatdiemHS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxemmon = new System.Windows.Forms.Button();
            this.cmbmamon = new System.Windows.Forms.ComboBox();
            this.txtdiemtb = new System.Windows.Forms.TextBox();
            this.txttenhs = new System.Windows.Forms.TextBox();
            this.txtiddiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.Dgvdiemcapnhat = new System.Windows.Forms.DataGridView();
            this.IDdiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvdiemcapnhat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxemmon);
            this.groupBox1.Controls.Add(this.cmbmamon);
            this.groupBox1.Controls.Add(this.txtdiemtb);
            this.groupBox1.Controls.Add(this.txtmahs);
            this.groupBox1.Controls.Add(this.txttenhs);
            this.groupBox1.Controls.Add(this.txtiddiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 179);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Điểm";
            // 
            // btnxemmon
            // 
            this.btnxemmon.Location = new System.Drawing.Point(612, 92);
            this.btnxemmon.Name = "btnxemmon";
            this.btnxemmon.Size = new System.Drawing.Size(75, 23);
            this.btnxemmon.TabIndex = 3;
            this.btnxemmon.Text = "Xem Môn ";
            this.btnxemmon.UseVisualStyleBackColor = true;
            this.btnxemmon.Click += new System.EventHandler(this.btnxemmon_Click);
            // 
            // cmbmamon
            // 
            this.cmbmamon.FormattingEnabled = true;
            this.cmbmamon.Location = new System.Drawing.Point(476, 94);
            this.cmbmamon.Name = "cmbmamon";
            this.cmbmamon.Size = new System.Drawing.Size(121, 21);
            this.cmbmamon.TabIndex = 2;
            // 
            // txtdiemtb
            // 
            this.txtdiemtb.Location = new System.Drawing.Point(476, 66);
            this.txtdiemtb.Name = "txtdiemtb";
            this.txtdiemtb.Size = new System.Drawing.Size(121, 21);
            this.txtdiemtb.TabIndex = 1;
            // 
            // txttenhs
            // 
            this.txttenhs.Location = new System.Drawing.Point(240, 121);
            this.txttenhs.Name = "txttenhs";
            this.txttenhs.Size = new System.Drawing.Size(130, 21);
            this.txttenhs.TabIndex = 1;
            // 
            // txtiddiem
            // 
            this.txtiddiem.Location = new System.Drawing.Point(240, 66);
            this.txtiddiem.Name = "txtiddiem";
            this.txtiddiem.Size = new System.Drawing.Size(130, 21);
            this.txtiddiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Tin Chi Tiết Điểm ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm Trung Bình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Điểm";
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Refresh";
            this.btnhuy.Location = new System.Drawing.Point(527, 185);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 62);
            this.btnhuy.TabIndex = 15;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "SaveAll";
            this.btnluu.Location = new System.Drawing.Point(446, 185);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 62);
            this.btnluu.TabIndex = 16;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.ImageUri.Uri = "Cancel";
            this.btnxoa.Location = new System.Drawing.Point(365, 185);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 62);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.ImageUri.Uri = "Edit";
            this.btnsua.Location = new System.Drawing.Point(284, 185);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 62);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(203, 185);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 62);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmahs
            // 
            this.txtmahs.Location = new System.Drawing.Point(240, 94);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(130, 21);
            this.txtmahs.TabIndex = 1;
            this.txtmahs.TextChanged += new System.EventHandler(this.txtmahs_TextChanged);
            // 
            // Dgvdiemcapnhat
            // 
            this.Dgvdiemcapnhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvdiemcapnhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvdiemcapnhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDdiem,
            this.MaHS,
            this.HoTen,
            this.DiemTB,
            this.MaMon});
            this.Dgvdiemcapnhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgvdiemcapnhat.Location = new System.Drawing.Point(0, 264);
            this.Dgvdiemcapnhat.Name = "Dgvdiemcapnhat";
            this.Dgvdiemcapnhat.Size = new System.Drawing.Size(811, 239);
            this.Dgvdiemcapnhat.TabIndex = 21;
            this.Dgvdiemcapnhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvdiemcapnhat_CellClick_1);
            // 
            // IDdiem
            // 
            this.IDdiem.DataPropertyName = "IdDiem";
            this.IDdiem.HeaderText = "Mã Điểm";
            this.IDdiem.Name = "IDdiem";
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã Học Sinh";
            this.MaHS.Name = "MaHS";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm Trung Bình";
            this.DiemTB.Name = "DiemTB";
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.Name = "MaMon";
            // 
            // CapnhatdiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 503);
            this.Controls.Add(this.Dgvdiemcapnhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Name = "CapnhatdiemHS";
            this.Text = "Cập Nhật Điểm Cho HS";
            this.Load += new System.EventHandler(this.CapnhatdiemHS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvdiemcapnhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxemmon;
        private System.Windows.Forms.ComboBox cmbmamon;
        private System.Windows.Forms.TextBox txtdiemtb;
        private System.Windows.Forms.TextBox txttenhs;
        private System.Windows.Forms.TextBox txtiddiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.DataGridView Dgvdiemcapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
    }
}
namespace QLhocsinhgiaovien
{
    partial class MonHoc
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
            this.dgvbangmon = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangmon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbangmon
            // 
            this.dgvbangmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbangmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbangmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon});
            this.dgvbangmon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvbangmon.Location = new System.Drawing.Point(0, 215);
            this.dgvbangmon.Name = "dgvbangmon";
            this.dgvbangmon.Size = new System.Drawing.Size(640, 245);
            this.dgvbangmon.TabIndex = 0;
            this.dgvbangmon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbangmon_CellClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMonHoc";
            this.TenMon.HeaderText = "Tên Môn Học";
            this.TenMon.Name = "TenMon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(210, 81);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(100, 21);
            this.txtMaMon.TabIndex = 2;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(343, 84);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(48, 13);
            this.labe.TabIndex = 1;
            this.labe.Text = "Tên Môn";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(397, 81);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(100, 21);
            this.txtTenMon.TabIndex = 2;
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Refresh";
            this.btnhuy.Location = new System.Drawing.Point(453, 137);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 62);
            this.btnhuy.TabIndex = 20;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "SaveAll";
            this.btnluu.Location = new System.Drawing.Point(372, 137);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 62);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.ImageUri.Uri = "Cancel";
            this.btnxoa.Location = new System.Drawing.Point(291, 137);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 62);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.ImageUri.Uri = "Edit";
            this.btnsua.Location = new System.Drawing.Point(210, 137);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 62);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(129, 137);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 62);
            this.btnthem.TabIndex = 24;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Môn Học";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvbangmon);
            this.Name = "MonHoc";
            this.Text = "Bảng Môn Học";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbangmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.TextBox txtTenMon;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.Label label3;
    }
}
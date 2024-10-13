namespace QuanLyPhongTro.ChildForm
{
    partial class fmLoaiPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDsLoaiPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý danh mục loại phòng";
            // 
            // dgvDsLoaiPhong
            // 
            this.dgvDsLoaiPhong.AllowUserToAddRows = false;
            this.dgvDsLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvDsLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsLoaiPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLoaiPhong.GridColor = System.Drawing.Color.Gray;
            this.dgvDsLoaiPhong.Location = new System.Drawing.Point(0, 107);
            this.dgvDsLoaiPhong.MultiSelect = false;
            this.dgvDsLoaiPhong.Name = "dgvDsLoaiPhong";
            this.dgvDsLoaiPhong.ReadOnly = true;
            this.dgvDsLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsLoaiPhong.Size = new System.Drawing.Size(799, 344);
            this.dgvDsLoaiPhong.TabIndex = 1;
            this.dgvDsLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsLoaiPhong_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(88, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại phòng: ";
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(188, 62);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(187, 20);
            this.txtTenLoaiPhong.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(439, 62);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(84, 20);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.Text = "0";
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(382, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá:";
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(555, 61);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(73, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "+Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(634, 61);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Cập nhật";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(715, 61);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Xác nhận";
            this.btnluu.UseVisualStyleBackColor = false;
            // 
            // fmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLoaiPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDsLoaiPhong);
            this.Controls.Add(this.label1);
            this.Name = "fmLoaiPhong";
            this.Text = "fmLoaiPhong";
            this.Load += new System.EventHandler(this.fmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoaiPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
    }
}
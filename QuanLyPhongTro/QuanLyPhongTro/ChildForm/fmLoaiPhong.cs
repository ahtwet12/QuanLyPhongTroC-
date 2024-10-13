using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.ChildForm
{
    public partial class fmLoaiPhong : Form
    {
        public fmLoaiPhong()
        {
            InitializeComponent();
        }
        private Database db ;

        private int maLoaiPhong = 0;

        //Them loai phong
        private void btnthem_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txtTenLoaiPhong.Text;
            var donGia = int.Parse(txtDonGia.Text);
            //rang buoc dlieu
            if (string.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập đúng tên loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ctrinh 
            }
            if(donGia < 50000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 50.000", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ctrinh 
            }

            var prList = new List<CustomParameter>();
            prList.Add(new CustomParameter
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            }) ;
            prList.Add(new CustomParameter
            {
                key = "@donGia",
                value = donGia.ToString()
            });

            var rs = db.ExeCute("themLoaiPhong", prList);
            if(rs == 1)
            {
                MessageBox.Show("Thêm mới loại phòng thành công !", "Successfully !!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaiDsLoaiPhong();
                txtDonGia.Text = "0";
                txtTenLoaiPhong.Text = null;
            }
        }

        private void LoaiDsLoaiPhong()
        {
           
            dgvDsLoaiPhong.DataSource = db.SelectData("loaiDsLoaiPhong");
        }

        private void fmLoaiPhong_Load(object sender, EventArgs e)
        {
            db = new Database();

            LoaiDsLoaiPhong();
            dgvDsLoaiPhong.Columns[0].Width = 100;
            dgvDsLoaiPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiPhong.Columns[0].HeaderText = "Mã Loại";

            dgvDsLoaiPhong.Columns[2].Width = 200;
            dgvDsLoaiPhong.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiPhong.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDsLoaiPhong.Columns[2].HeaderText = "Đơn Giá";

            dgvDsLoaiPhong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDsLoaiPhong.Columns[1].HeaderText = "Tên Loại Phòng";
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // đặt điều kiện chỉ cho phép nhập số  , kh cho nhập kí tự khác 
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDsLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                maLoaiPhong = int.Parse(dgvDsLoaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenLoaiPhong.Text = dgvDsLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDsLoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        // sửa - cập nhật
        private void btnsua_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txtTenLoaiPhong.Text;
            var donGia = int.Parse(txtDonGia.Text);
            //rang buoc dlieu
            if (maLoaiPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ctrinh 
            }
            if (string.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập đúng tên loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ctrinh 
            }
            if (donGia < 50000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 50.000", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ctrinh 
            }

            var prList = new List<CustomParameter>();
            //ánh xạ
            prList.Add(new CustomParameter
            {
                key = "@idLoaiPhong",
                value = maLoaiPhong.ToString()
            });
            prList.Add(new CustomParameter
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });
            prList.Add(new CustomParameter
            {
                key = "@donGia",
                value = donGia.ToString()
            });

            var rs = db.ExeCute("capNhatLoaiPhong", prList);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật loại phòng thành công !", "Successfully !!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaiDsLoaiPhong();
                txtDonGia.Text = "0";
                maLoaiPhong = 0;
                txtTenLoaiPhong.Text = null;
            }
        }
    }
}

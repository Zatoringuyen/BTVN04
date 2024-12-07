using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_B4
{
    public partial class FormNhanVien : Form
    {
        public NhanVien NhanVienMoi { get; set; }
        
        public FormNhanVien()

        {
            InitializeComponent();

        }
        // Constructor cho chức năng Sửa
        public FormNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();

            txtMsnv.Text = nhanVien.MSNV;
            txtTen.Text = nhanVien.TenNV;
            txtLuong.Text = nhanVien.LuongCB.ToString();
            NhanVienMoi = nhanVien;
        }
        

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(txtMsnv.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtLuong.Text, out double luongCB))
            {
                MessageBox.Show("Lương cơ bản phải là số.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu thêm mới nhân viên
            if (NhanVienMoi == null)
            {
                NhanVienMoi = new NhanVien
                {
                    MSNV = txtMsnv.Text.Trim(), 
                    TenNV = txtTen.Text.Trim(), 
                    LuongCB = luongCB 
                };
            }
            else
            {
                // Nếu sửa nhân viên hiện tại
                NhanVienMoi.TenNV = txtTen.Text.Trim(); 
                NhanVienMoi.LuongCB = luongCB; 
                                              
            }

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}


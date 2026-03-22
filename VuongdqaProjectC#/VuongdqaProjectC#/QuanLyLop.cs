using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuongdqaProjectC_
{
    public partial class QuanLyLop : Form
    {
      
        dbDataContext db = new dbDataContext();
        public QuanLyLop()
        {
            InitializeComponent();
            
            this.Load += Form1_Load;
            button1.Click += button1_Click; // Thêm
            button2.Click += button2_Click; // Sửa
            button3.Click += button3_Click; // Cập nhật (reload)
            button4.Click += button4_Click; // Xóa
            button5.Click += button5_Click; // Tìm kiếm
            dataGridView1.CellClick += dataGridView1_CellClick;

           
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
           
            var list = db.QuanlyLops.ToList();
            dataGridView1.DataSource = list;
        }

        private void ClearInput()
        {
            textBox1.Clear(); // Tên lớp
            textBox2.Clear(); // Mã lớp
            textBox3.Clear(); // Số sinh viên
            textBox4.Clear(); // tìm kiếm
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Thêm lớp
            string tenLop = textBox1.Text.Trim();
            string maLop = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên lớp và Mã lớp", "Thông báo");
                return;
            }

            // Kiểm tra tồn tại theo MaLop hoặc Tên lớp
            var check = db.QuanlyLops.SingleOrDefault(x => x.MaLop == maLop || x.Lop == tenLop);
            if (check != null)
            {
                MessageBox.Show("Lớp này đã tồn tại!", "Thông báo");
                ClearInput();

                return;
            }

            var lop = new QuanlyLop();
            lop.Lop = tenLop;
            lop.MaLop = maLop;
            int so = 0;
            if (int.TryParse(textBox3.Text.Trim(), out so))
                lop.SoSinhVien = so;

            db.QuanlyLops.InsertOnSubmit(lop);
            db.SubmitChanges();

            MessageBox.Show("Thêm thành công!");
            LoadData();
            ClearInput();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sửa lớp: tìm theo MaLop nếu có
            string maLop = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp để sửa", "Thông báo");
                return;
            }

            var lop = db.QuanlyLops.SingleOrDefault(x => x.MaLop == maLop);
            if (lop == null)
            {
                MessageBox.Show("Không tìm thấy lớp để sửa", "Thông báo");
                return;
            }

            DialogResult dr = MessageBox.Show("Xác nhận sửa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes) return;

            try
            {
                // Cập nhật các trường (không bắt buộc phải đổi khóa chính nhưng cho phép đổi tên lớp)
                lop.Lop = textBox1.Text.Trim();
                lop.MaLop = maLop;
                int so = 0;
                if (int.TryParse(textBox3.Text.Trim(), out so))
                    lop.SoSinhVien = so;

                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Xóa lớp (xóa thực tế)
            string maLop = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp để xóa", "Thông báo");
                return;
            }

            var lop = db.QuanlyLops.SingleOrDefault(x => x.MaLop == maLop);
            if (lop == null)
            {
                MessageBox.Show("Không tìm thấy lớp để xóa", "Thông báo");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có muốn xoá lớp này?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.QuanlyLops.DeleteOnSubmit(lop);
                db.SubmitChanges();
                LoadData();
                ClearInput();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cập nhật giao diện: load lại dữ liệu và xóa input
            LoadData();
            ClearInput();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tuKhoa = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadData();
                return;
            }

            var ketQua = db.QuanlyLops
                           .Where(x => x.Lop.Contains(tuKhoa) || x.MaLop.Contains(tuKhoa))
                           .ToList();
            dataGridView1.DataSource = ketQua;
            if (ketQua.Count == 0)
                MessageBox.Show("Không tìm thấy lớp nào khớp với từ khóa!", "Thông báo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Cẩn trọng khi giá trị null
                if (row.Cells["Lop"].Value != null)
                    textBox1.Text = row.Cells["Lop"].Value.ToString();
                if (row.Cells["MaLop"].Value != null)
                    textBox2.Text = row.Cells["MaLop"].Value.ToString();
                if (row.Cells["SoSinhVien"].Value != null)
                    textBox3.Text = row.Cells["SoSinhVien"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

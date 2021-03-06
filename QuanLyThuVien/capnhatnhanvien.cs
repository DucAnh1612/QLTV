using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class capnhatnhanvien : Form
    {
        public capnhatnhanvien()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void capnhatnhanvien_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1,"select * from tblNhanVien where TAIKHOAN='"+Main.TenDN+"'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text.Length - 1 <= 0)
                MessageBox.Show("Số điện thoại không thể nhỏ hơn 0 số");
            else
                if (txtSoDienThoai.Text.Length - 1 > 12)
                    MessageBox.Show("Số điện thoại không thể lớn hơn 12 số");
                else
                    if (textBox2.Text.Length - 1 <= 18 && textBox2.Text.Length - 1 > 55)
                        MessageBox.Show("sai tuổi");
                    else
                    {
                        string strUpdate = "update tblNhanVien set TENNV='" + txtNHANVIEN.Text + "',DIACHI='" + txtDiaChi.Text + "',DIENTHOAI='" + txtSoDienThoai.Text + "',EMAIL='" + txtEmail.Text + "',ChucVu='" + textBox1.Text + "',Tuoi='" + textBox2.Text + "' where TAIKHOAN='" + Main.TenDN + "'";
                        cls.ThucThiSQLTheoKetNoi(strUpdate);
                    }
            cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");
            MessageBox.Show("Sửa thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNHANVIEN.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string strDelete = "delete from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'";
            //cls.ThucThiSQLTheoPKN(strDelete);
            //cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");
            //MessageBox.Show("Xóa thành công");
        }
    }
}

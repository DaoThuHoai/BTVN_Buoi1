using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (textBoxDangNhap.Text == "abc" && textBoxMatKhau.Text == "123")
            {
                lblthongbao.Text = "Đăng nhập thành công";
                lblthongbao.ForeColor = Color.Black;
                groupBoxThemSV.Visible = true;
            }
            else
            {
                lblthongbao.Text = "Đăng nhập thất bại";
                lblthongbao.ForeColor = Color.Red;
                groupBoxThemSV.Visible = false;
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxThemSV.Visible = false;
        }

        private void groupBoxThemSV_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            if (textBoxTenSV.Text == "" || textBoxMaSv.Text == " ")
            {
                MessageBox.Show("Chưa nhập mã sinh viên hoặc tên sinh viên ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                dGVThemSV.Rows.Add(textBoxMaSv.Text, textBoxTenSV.Text);
        }
    }
}
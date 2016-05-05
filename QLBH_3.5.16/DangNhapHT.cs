using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_3._5._16
{
    public partial class DangNhapHT : Form
    {
        public DangNhapHT()
        {
            InitializeComponent();
        }

        string connection = @"Data Source=DESKTOP-15RE755\SQLEXPRESS;Initial Catalog=PHILONG;Integrated Security=True";
        SqlConnection cn;
        SqlDataAdapter da;
        string sql;
        DataSet ds;
        int quyen;

        private void DangNhapHT_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_HT_Click(object sender, EventArgs e)
        {
           if (txtTaiKhoan_HT.Text =="")
           {
               MessageBox.Show("CẦN NHẬP TÊN NGƯỜI DÙNG ĐỂ ĐĂNG NHẬP", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
            else
           {
               if (txtMatKhau_HT.Text == "")
                   MessageBox.Show("CẦN NHẬP MẬT KHẨU ĐỂ ĐĂNG NHẬP", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               else
               {
                   cn = new SqlConnection(connection);
                   sql = "select * from TAIKHOAN where TenTaiKhoan = N'" + txtTaiKhoan_HT.Text + "'and MatKhau = N'" + txtMatKhau_HT.Text + "'";
                   da = new SqlDataAdapter(sql, cn);
                   ds = new DataSet("TAIKHOAN");
                   da.Fill(ds, "TAIKHOAN");
                   if (ds.Tables[0].Rows.Count>0)
                   {
                       frmHeThong frm = new frmHeThong();
                       frm.Show();
                       //this.Close();
                       Program.quyen = int.Parse(ds.Tables[0].Rows[0][2].ToString());
                       Program.taikhoan = ds.Tables[0].Rows[0].ToString();
                   }
                   else
                   {
                       MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   }
                   cn.Close();
                   cn.Dispose();
               }
           };
        }

        private void btnThoat_HT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

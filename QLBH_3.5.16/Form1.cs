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
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        string connection = @"Data Source=DESKTOP-15RE755\SQLEXPRESS;Initial Catalog=PHILONG;Integrated Security=True";
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        string sql;
        int dem;
        int k;
        string MaLoaiHangCapNhat;

        private void btnThoatHeThong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);// mở kết nối đến sql
            sql = "select * from LOAIHANG";//tạo chuỗi kết nối
            SqlCommand com = new SqlCommand(sql, cn);//khai báo một command để truy vấn dữ liệu
            com.CommandType = CommandType.Text;// khao báo kiểu command
            da = new SqlDataAdapter(com);//vận chuyển dữ liệu về

            DataTable dt = new DataTable();// tạo một kho ảo để lưu dữ liệu
            da.Fill(dt);//đưa dữ liệu vào kho

            cboLoaiHang_BH.DataSource = dt;//đưa dữ liệu vào cboLoaiHang
            cboLoaiHang_BH.ValueMember = "MaLoaiHang";
            cboLoaiHang_BH.DisplayMember = "TenLoaiHang";

            cboLoaiHang_BH.SelectedIndex = 0;
            cn.Close();
            cn.Dispose();
        }

        
        private void HienThiLoaiHang()
        {
            cn = new SqlConnection(connection);
            sql = "select * from LOAIHANG";
            da = new SqlDataAdapter(sql, cn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dgvLuoiDL_LH.DataSource = dt1;
            cn.Close();
            cn.Dispose();
        }
        private void btnHienThi_LH_Click(object sender, EventArgs e)
        {
            HienThiLoaiHang();
        }

        private void btnLuu_LH_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiHang_LH != null && txtTenLoaiHang_LH != null)
            {
                cn = new SqlConnection(connection);
                sql = "INSERT into LOAIHANG values (N'" + txtMaLoaiHang_LH.Text.ToString() + "',N'" + txtTenLoaiHang_LH.Text.ToString()
                    + "',N'" + txtMoTa_LH.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                // Hiện thị lên bảng dữ liệu
                cn = new SqlConnection(connection);
                sql = "select * from LOAIHANG";
                da = new SqlDataAdapter(sql, cn);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                dgvLuoiDL_LH.DataSource = dt1;
                cn.Close();
                cn.Dispose();
            }
            else
                MessageBox.Show("Cần nhập đầy đủ Mã loại hàng và Tên loại hàng", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dgvLuoiDL_LH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; // i là số thứ tự của dòng
            MaLoaiHangCapNhat = dgvLuoiDL_LH[0, i].Value.ToString();
            txtMaLoaiHang_LH.Text = dgvLuoiDL_LH[0, i].Value.ToString();
            txtMaLoaiHang_LH.Enabled = false;
            txtTenLoaiHang_LH.Text = dgvLuoiDL_LH[1, i].Value.ToString();
            txtMoTa_LH.Text = dgvLuoiDL_LH[2, i].Value.ToString();
        }

        private void btnCapNhat_LH_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "UPDATE LOAIHANG set TenLoaiHang = N'" + txtTenLoaiHang_LH.Text.ToString() + "',MoTa = N'" + txtMoTa_LH.Text.ToString()
                + "'where MaLoaiHang = N'" + MaLoaiHangCapNhat.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            HienThiLoaiHang();

        }

        private void btnXoa_LH_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có thực sự muốn xóa?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (chon == DialogResult.Yes)
            {
                try
                {
                    cn = new SqlConnection(connection);
                    sql = "DELETE from LOAIHANG where MaLoaiHang=N'" + MaLoaiHangCapNhat.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Dispose();
                    HienThiLoaiHang();

                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }

        private void btnRefresh_LH_Click(object sender, EventArgs e)
        {
            txtMaLoaiHang_LH.Clear();
            txtMaLoaiHang_LH.Enabled = true;
            txtTenLoaiHang_LH.Clear();
            txtMaLoaiHang_LH.Clear();
            txtMoTa_LH.Clear();
        }

        private void btnThoat_LH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region BAN HANG

        private void cboLoaiHang_BH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "select * from HANGHOA where MaLoaiHang = '" + cboLoaiHang_BH.SelectedValue.ToString() + "'";
            da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLuoiDL_BH.DataSource = dt;
            cn.Close();
            cn.Dispose();
            HienThiHangHoa();
        }

        private void btnLuu_BH_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "INSERT into HANGHOA values (N'" + txtMaHang_BH.Text.ToString() + "',N'" + cboLoaiHang_BH.SelectedValue.ToString() + "',N'"
                 + txtTenHang_BH.Text.ToString() + "',N'" + txtSoLuong_BH.Text.ToString() + "',N'" + txtDonGia_BH.Text.ToString() + "',N'"
                 + txtDonViTinh_BH.Text.ToString() + "',N'" +null+"')";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            HienThiHangHoa();
           
        }

        private void HienThiHangHoa()
        {
            cn = new SqlConnection(connection);
            sql = "select * from HANGHOA";
            da = new SqlDataAdapter(sql, cn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dgvLuoiDL_BH.DataSource = dt1;
            cn.Close();
            cn.Dispose();
        }

    }
}
        #endregion
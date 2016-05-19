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
using BussinessLogicLayer;

namespace QLBH_3._5._16
{
    public partial class frmHeThong : Form
    {
        LoaiHang_BLL lhbll = new LoaiHang_BLL();
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
        string MaHangHoaCapNhat;

        private void btnThoatHeThong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            dgvLuoiDL_LH.DataSource = lhbll.LOAIHANG_Select();

            //cboLoaiHang_BH.DataSource = dt;//đưa dữ liệu vào cboLoaiHang
            //cboLoaiHang_BH.ValueMember = "MaLoaiHang";
            //cboLoaiHang_BH.DisplayMember = "TenLoaiHang";

            //cboLoaiHang_BH.SelectedIndex = 0;
            
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

            lhbll.LOAIHANG_Insert(txtMaLoaiHang_LH.Text, txtTenLoaiHang_LH.Text, txtMoTa_LH.Text);
            btnHienThi_LH_Click(sender, e);

        }

        private void dgvLuoiDL_LH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; // i là số thứ tự của dòng
            MaLoaiHangCapNhat = dgvLuoiDL_LH[0, i].Value.ToString();
            txtMaLoaiHang_LH.Text = dgvLuoiDL_LH[0, i].Value.ToString();
            txtMaLoaiHang_LH.Enabled = false;
            txtTenLoaiHang_LH.Text = dgvLuoiDL_LH[1, i].Value.ToString();
            txtMoTa_LH.Text = dgvLuoiDL_LH[2, i].Value.ToString();
            btnCapNhat_BH.Enabled = true;
        }

        private void btnCapNhat_LH_Click(object sender, EventArgs e)
        {
            lhbll.LOAIHANG_Update(txtMaLoaiHang_LH.Text, txtTenLoaiHang_LH.Text, txtMoTa_LH.Text);
            btnHienThi_LH_Click(sender, e);

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
            this.Hide();
            DangNhapHT formDT = new DangNhapHT();
            formDT.Show();
        }
        
        #region BAN HANG

        private void cboLoaiHang_BH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "select * from HANGHOA where MaLoaiHang = '" + cboLoaiHang_BH.SelectedValue.ToString() + "'";
            da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    cboLoaiHang_BH.DataSource = dt;
            //    //cboLoaiHang_BH.DataSource = dt;
            //    cboLoaiHang_BH.ValueMember = "MaLoaiHang";
            //    cboLoaiHang_BH.DisplayMember = "TenLoaiHang";
            //    cboLoaiHang_BH.SelectedIndex = 0;
            //}
            dgvLuoiDL_BH.DataSource = dt;
            cn.Close();
            cn.Dispose();
            //HienThiHangHoa();
        }

        private void btnLuu_BH_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "INSERT into HANGHOA values (N'" + txtMaHangHoa_BH.Text.ToString() + "',N'" + cboLoaiHang_BH.SelectedValue.ToString() + "',N'"
                 + txtTenHangHoa_BH.Text.ToString() + "',N'" + txtSoLuong_BH.Text.ToString() + "',N'" + txtDonGia_BH.Text.ToString() + "',N'"
                 + txtDonViTinh_BH.Text.ToString() + "')";
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

        private void btnHienThi_BH_Click(object sender, EventArgs e)
        {
            HienThiHangHoa();
        }

        private void dgvLuoiDL_BH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; // i là số thứ tự của dòng
            MaHangHoaCapNhat = dgvLuoiDL_BH[0, i].Value.ToString();
            txtMaHangHoa_BH.Text = dgvLuoiDL_BH[0, i].Value.ToString();
            txtMaHangHoa_BH.Enabled = false;
            txtTenHangHoa_BH.Text = dgvLuoiDL_BH[2, i].Value.ToString();
            txtSoLuong_BH.Text = dgvLuoiDL_BH[3, i].Value.ToString();
            txtDonGia_BH.Text = dgvLuoiDL_BH[4, i].Value.ToString();
            txtDonViTinh_BH.Text = dgvLuoiDL_BH[5, i].Value.ToString();

        }

        private void btnCapNhat_BH_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "UPDATE HANGHOA set TenHangHoa = N'" + txtTenHangHoa_BH.Text.ToString() + "',SoLuong = N'" + txtSoLuong_BH.Text.ToString() + "',DonGia = N'" + txtDonGia_BH.Text.ToString() + "',DonViTinh = N'" + txtDonViTinh_BH.Text.ToString()
                + "'where MaHangHoa = N'" + MaHangHoaCapNhat.ToString() + "'"; 
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            HienThiHangHoa();
        }

        private void btnXoa_BH_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có thực sự muốn xóa?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (chon == DialogResult.Yes)
            {
                try
                {
                    cn = new SqlConnection(connection);
                    sql = "DELETE from HANGHOA where MaHangHoa=N'" + MaHangHoaCapNhat.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Dispose();
                    HienThiHangHoa();

                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }

        private void btnRefresh_BH_Click(object sender, EventArgs e)
        {
            txtMaHangHoa_BH.Clear();
            txtMaHangHoa_BH.Enabled = true;
            txtTenHangHoa_BH.Clear();
            txtMaHangHoa_BH.Clear();
            txtSoLuong_BH.Clear();
            txtDonGia_BH.Clear();
            txtDonViTinh_BH.Clear();
        }

        private void btnThoat_BH_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapHT formDT = new DangNhapHT();
            formDT.Show();
        }

        private void txtTimKiem_BH_TextChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection);
            sql = "select * from HANGHOA where TenHangHoa like N'%" + txtTimKiem_BH.Text.Trim() + "%'";
            da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLuoiDL_BH.DataSource = dt;
            cn.Close();
            cn.Dispose();
        }

        private void btnChonTep_NV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDlg1 = new OpenFileDialog();
            openfileDlg1.Filter = openfileDlg1.Filter = "JPG file (*.jpg)|*.jpg|All files (*.*)|*.*";
            openfileDlg1.FilterIndex = 1;
            openfileDlg1.RestoreDirectory = true;
            if (openfileDlg1.ShowDialog () == DialogResult.OK)
            {
                picAnhNV_NV.ImageLocation = openfileDlg1.FileName;
                txtDuongDanAnh_NV.Text = openfileDlg1.FileName;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void btnXacNhan_NV_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cn = new SqlConnection(connection);
        //        sql = "insert into NHANVIEN values (@ANHNV)
        //        SqlCommand cmd = new SqlCommand(sql, cn);
        //        cn.Open();
        //        cmd.ExecuteNonQuery();
        //        cn.Close();
        //        cn.Dispose();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //LoaiHang_BLL LHbll = new LoaiHang_BLL();
        
        //private void btnHienThi_LH_Click(object sender, EventArgs e)
        //{
        //    dgvLuoiDL_LH.DataSource = LHbll.LOAIHANG_Select();
        //}

        //private void btnLuu_LH_Click(object sender, EventArgs e)
        //{
        //    LHbll.LOAIHANG_Insert(txtMaLoaiHang_LH.Text, txtTenLoaiHang_LH.Text, txtMoTa_LH.Text);
        //    //gọi lại hàm hiển thị để xem kết quả sau khi Thêm Sinh Viên
        //    btnHienThi_LH_Click(sender, e);
        //}

        //private void btnCapNhat_LH_Click(object sender, EventArgs e)
        //{
        //    LHbll.LOAIHANG_Update(txtMaLoaiHang_LH.Text, txtTenLoaiHang_LH.Text, txtMoTa_LH.Text);
        //    btnHienThi_LH_Click(sender, e);
        //}

        //private void btnXoa_LH_Click(object sender, EventArgs e)
        //{
        //    LHbll.LOAIHANG_Delete(txtMaLoaiHang_LH.Text);
        //    btnHienThi_LH_Click(sender, e);
        //}
        //string idsv;
        //private void dgvLuoiDL_LH(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtMaLoaiHang_LH.Text = dgvLuoiDL_LH.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    txtTenLoaiHang_LH.Text = dgvLuoiDL_LH.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    txtMoTa.Text = dgvLuoiDL_LH.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        //}
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
    }
}
        #endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_1_DotNet
{
    public partial class FrmDetailDT : Form
    {
        string connectionString = "Data Source=PHONGPHONG28\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";

        string maDT;
        string tenDeTai;
        string moTa;
        string maSV;
        string maGV;
        string linhVuc;
        string trangThai;
        string giaiThuong;
        string nhanXet;
        string khoaVien;

        Dictionary<string, string> fields = new Dictionary<string, string>();
        Dictionary<string, string> faculties = new Dictionary<string, string>();
        Dictionary<string, string> statuses = new Dictionary<string, string>();
        Dictionary<string, string> rewards = new Dictionary<string, string>();

        public FrmDetailDT(
            string maDT,
            string tenDeTai,
            string maSV,
            string maGV,
            string linhVuc,
            string trangThai,
            string giaiThuong,
            string nhanXet,
            string khoaVien
        )
        {
            InitializeComponent();

            this.maDT = maDT;
            this.tenDeTai = tenDeTai;
            this.moTa = moTa;
            this.maSV = maSV;
            this.maGV = maGV;
            this.linhVuc = linhVuc;
            this.trangThai = trangThai;
            this.giaiThuong = giaiThuong;
            this.nhanXet = nhanXet;
            this.khoaVien = khoaVien;

            dtName.Text = tenDeTai.ToUpper();
            detaiName.Text = tenDeTai;
            detaiDesc.Text = moTa;
            detaiStudent.Text = maSV;
            detaiTeacher.Text = maGV;
            detaiComment.Text = nhanXet;

            prefillFields();
            prefillGiaithuong();
            prefillKhoaVien();
            prefillTrangThai();
        }

        private void prefillFields()
        {
            string query = "SELECT * FROM LinhVuc";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var maLinhVuc = reader["MALINHVUC"] as string;
                        var tenLinhVuc = reader["TENLINHVUC"] as string;

                        fields.Add(maLinhVuc, tenLinhVuc);
                    }
                }
            }

            detaiField.Items.AddRange(fields.Values.ToArray());
            detaiField.SelectedItem = fields[linhVuc];
        }

        private void prefillTrangThai()
        {
            string query = "SELECT * FROM TrangThai";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var code = reader["MATRANGTHAI"] as string;
                        var name = reader["TENTRANGTHAI"] as string;

                        statuses.Add(code, name);
                    }
                }
            }

            detaiStatus.Items.AddRange(statuses.Values.ToArray());
            detaiStatus.SelectedItem = statuses[trangThai];
        }

        private void prefillKhoaVien()
        {
            string query = "SELECT * FROM Khoa";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var code = reader["MAKHOA"] as string;
                        var name = reader["TENKHOA"] as string;

                        faculties.Add(code, name);
                    }
                }
            }

            detaiFaculty.Items.AddRange(faculties.Values.ToArray());
            detaiFaculty.SelectedItem = faculties[khoaVien];
        }

        private void prefillGiaithuong()
        {
            string query = "SELECT * FROM Giaithuong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var code = reader["MAGIAITHUONG"] as string;
                        var name = reader["TENGIAITHUONG"] as string;

                        rewards.Add(code, name);
                    }
                }
            }

            detaiReward.Items.AddRange(rewards.Values.ToArray());
            if(giaiThuong != null && giaiThuong != "")
                detaiReward.SelectedItem = rewards[giaiThuong];
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE DeTaiNCKH" +
                    " SET TENDT = @TENDT, MOTA = @MOTA, MALINHVUC = @MALINHVUC, MAKHOA = @MAKHOA, MATRANGTHAI = @MATRANGTHAI, MAGIAITHUONG = @MAGIAITHUONG, NHANXET = @NHANXET " +
                    " WHERE MADT = @MADT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MADT", maDT);
                cmd.Parameters.AddWithValue("@TENDT", detaiName.Text);
                cmd.Parameters.AddWithValue("@MOTA", detaiDesc.Text);
                cmd.Parameters.AddWithValue("@MALINHVUC", fields.Where((entry) => entry.Value == detaiField.Text).ToList()[0].Key);
                cmd.Parameters.AddWithValue("@MAKHOA", faculties.Where((entry) => entry.Value == detaiFaculty.Text).ToList()[0].Key);
                cmd.Parameters.AddWithValue("@MATRANGTHAI", statuses.Where((entry) => entry.Value == detaiStatus.Text).ToList()[0].Key);
                cmd.Parameters.AddWithValue("@MAGIAITHUONG", rewards.Where((entry) => entry.Value == detaiReward.Text).ToList()[0].Value);
                cmd.Parameters.AddWithValue("@NHANXET", detaiComment.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class FrmDuyetDT : Form
    {
        public FrmDuyetDT()
        {
            InitializeComponent();
        }

        private void FrmDuyetDT_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PHONGPHONG28\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";

            string query = "SELECT * FROM DeTaiNCKH";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                var maDT = row.Cells[1].Value.ToString();
                var tenDT = row.Cells[2].Value.ToString();
                var moTa = row.Cells[3].Value.ToString();
                var linhVuc = row.Cells[4].Value.ToString();
                var maSV = row.Cells[5].Value.ToString();
                var maKhoa = row.Cells[6].Value.ToString();
                var maGV = row.Cells[7].Value.ToString();
                var maTrangThai = row.Cells[9].Value.ToString();
                var maGiaiThuong = row.Cells[10].Value.ToString();
                var nhanXet = row.Cells[11].Value.ToString();

                FrmDetailDT form = new FrmDetailDT(maDT, tenDT, maSV, maGV, linhVuc, maTrangThai, maGiaiThuong, nhanXet, maKhoa);
                form.Show();
            }
        }
    }
}

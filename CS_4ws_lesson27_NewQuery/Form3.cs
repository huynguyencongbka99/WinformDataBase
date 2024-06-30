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

namespace CS_4ws_lesson27_NewQuery
{
    public partial class Form3 : Form
    {
        private SqlConnection _sqlConnection3 = null;
        public Form3()
        {
            InitializeComponent();
            string connectionString = "Server = HuyNguyen\\TONYNGUYEN; database = DatabaseTest; User Id = sa; password = Nchbka1999";
            _sqlConnection3 = new SqlConnection(connectionString);
            try
            {
                _sqlConnection3.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToListView()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "Select * from SanPham";
            sqlcmd.Connection = _sqlConnection3;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while(reader.Read())
            {
                int ma = reader.GetInt32(0);
                string hoten = reader.GetString(1);
                int dongia = reader.GetInt32(2);
                int madanhmuc = reader.GetInt32(3);

                ListViewItem lvi = new ListViewItem(ma.ToString());
                lvi.SubItems.Add(hoten);
                lvi.SubItems.Add(dongia.ToString());
                lvi.SubItems.Add(madanhmuc.ToString());

                listView1.Items.Add(lvi);
            }
            reader.Close();
            
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            LoadDataToListView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _sqlConnection3.Close();
            this.Close();
        }

        private void btnGoToForm4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}

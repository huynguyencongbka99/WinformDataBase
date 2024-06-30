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
    public partial class Form1 : Form
    {
        public static SqlConnection _sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDatabase()
        {
            try
            {
                string connectionString = "Server = HuyNguyen\\TONYNGUYEN; database = DatabaseTest; User Id = sa; password = Nchbka1999";
                _sqlConnection = new SqlConnection(connectionString);
                _sqlConnection.Open();
                if(_sqlConnection.State == ConnectionState.Open)
                {
                    lblStatus.Text = "Connected";
                    lblStatus.BackColor = Color.Green;
                    grTacVu.Enabled = true;
                }
                MessageBox.Show("Connected to the database!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            InitializeDatabase();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sqlConnection != null)
                {
                    _sqlConnection.Close();
                    lblStatus.Text = "Disconnected";
                    lblStatus.BackColor = Color.Red;
                    MessageBox.Show("Disconnected!");
                }
                grTacVu.Enabled = false;
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnDemSoSanPham_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select count (*) from SanPham";
            cmd.Connection = _sqlConnection;

            object data = cmd.ExecuteScalar();

            int n = (int)data;
            lblSoSanPham.Text = n.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_sqlConnection != null)
            {
                _sqlConnection.Close();
            }
            this.Close();
        }


        private void LoadDataToDataGridView()
        {
            string query = "SELECT * FROM SanPham"; // Replace YourTableName with your actual table name

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data to DataGridView: {ex.Message}");
            }
        }

        private void btn_GoToForm2_Click(object sender, EventArgs e)
        {
            frm2 frm = new frm2();
            frm.Show();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}

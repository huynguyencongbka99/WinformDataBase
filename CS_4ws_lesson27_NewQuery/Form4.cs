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
    public partial class Form4 : Form
    {
        private SqlConnection _sqlConnection4= null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = "Server = HuyNguyen\\TONYNGUYEN; database = DatabaseTest; User Id = sa; password = Nchbka1999";
            _sqlConnection4 = new SqlConnection(connectionString);
            try
            {
                _sqlConnection4.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}");
            }
        }

        private void LoadDataToListView()
        {
            string query = "SELECT * FROM SanPham"; // Replace YourTableName with your actual table name

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _sqlConnection4);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Clear existing columns and items
                listView1.Clear();

                // Add columns to ListView
                foreach (DataColumn column in dataTable.Columns)
                {
                    listView1.Columns.Add(column.ColumnName);
                }

                // Add rows to ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem listViewItem = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dataTable.Columns.Count; i++)
                    {
                        listViewItem.SubItems.Add(row[i].ToString());
                    }
                    listView1.Items.Add(listViewItem);
                }

                // Auto resize columns to fit data
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data to ListView: {ex.Message}");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataToListView();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sqlConnection4 != null && _sqlConnection4.State == ConnectionState.Open)
            {
                _sqlConnection4.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frm2 : Form
    {
        public static SqlConnection _sqlConnection2 = null;
        public frm2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server = HuyNguyen\\TONYNGUYEN; database = DatabaseTest; User Id = sa; password = Nchbka1999";
                _sqlConnection2 = new SqlConnection(connectionString);
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form 2 cann't Connected to the database!" + ex.Message);
            }
        }

        private void lblMa_Click(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlConnection2.Close();
                _sqlConnection2.Open();
                if (txtMa.Text != "")
                {
                    txtDonGia.Enabled = true;
                    txtMaDanhMuc.Enabled = true;
                    txtTen.Enabled = true;

                    //int a;
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from SanPham Where Ma = @ma";
                    cmd.Connection = _sqlConnection2;

                    
                    SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int);
                    Int32.TryParse(txtMa.Text, out int a1);
                    paraMa.Value = a1;
                    cmd.Parameters.Add(paraMa);


                    SqlDataReader sqlReader = cmd.ExecuteReader();
                    if (sqlReader.Read())
                    {
                        int a = sqlReader.GetInt32(0);
                        txtTen.Text = sqlReader.GetString(1);
                        int b = sqlReader.GetInt32(2);
                        int c = sqlReader.GetInt32(3);
                        txtMa.Text = a.ToString();
                        txtDonGia.Text = b.ToString();
                        txtMaDanhMuc.Text = c.ToString();

                    }
                    else
                    {
                        txtDonGia.Text = "";
                        txtMaDanhMuc.Text = "";
                        txtTen.Text = "";
                        MessageBox.Show("Khong tim thay data san pham co ma "+ txtMa.Text);
                    }

                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Ma khong duoc de trong, va phai la so tu nhien!" + "\n" + ex.Message);
            }
        }
    }
}

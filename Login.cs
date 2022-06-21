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

namespace PhoneStat
{
    public partial class Login : Form
    {
        SqlConnection conn = null;
        string stringConnect = Program.conStr;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserName.Text != "" && Password.Text != "")
                
            {
                if (conn == null)
                    conn = new SqlConnection(stringConnect);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "CheckLogin";
                        command.Connection = conn;

                        command.Parameters.Add("@username", SqlDbType.Text).Value = UserName.Text;
                        command.Parameters.Add("@passs", SqlDbType.Text).Value = Password.Text;


                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            reader.Close();
                            command.Dispose();
                            conn.Close();
                            MessageBox.Show("Login Successfully");
                            Program.isLoggedIn = true;
                        }
                        else
                        {
                            MessageBox.Show("Tên hoặc mật khẩu không đúng. Vui lòng kiểm tra lại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            

            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

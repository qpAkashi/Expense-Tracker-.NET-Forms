using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ExpenseTrackingApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordfield.PasswordChar = '*';
        }

        private void passwordfield_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            
            string username = usernamefield.Text;
            string password = passwordfield.Text;

            
            if (IsValidUser(username, password))
            {
                
                this.Hide();
                MainPage mainPage = new MainPage(); 
                mainPage.Show();
            }
            else
            {
                
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                passwordfield.PasswordChar = '\0';  
            }
            else
            {
                passwordfield.PasswordChar = '*';  
            }
        }

        
        private bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Rares\Desktop\temacs\ExpenseAppDB.accdb;Persist Security Info=False;";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password"; // Adjust as needed

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        
                        int count = (int)cmd.ExecuteScalar(); 

                        
                        if (count > 0)
                        {
                            isValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }
    }
}

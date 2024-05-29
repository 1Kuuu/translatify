using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Translatify1
{
    public partial class LoginForm : Form
    {
        private string conString = "Server=127.0.0.1;database=translatify_db;user=root;";
        MainForm main = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = true;
        }
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (eye.Checked)
            {
                passTxt.UseSystemPasswordChar = false;
            } else
            {
                passTxt.UseSystemPasswordChar = true;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string qry = "SELECT * FROM `users` WHERE username = @user AND password = @pass";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@user", userTxt.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", passTxt.Text.Trim());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Welcome " + reader.GetString("username"));
                    main.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Wrong Password or Username");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm form = new SignupForm(); 
            form.Show();
            this.Hide();
        }

        private void userTxt_Enter(object sender, EventArgs e)
        {
            
        }

        private void userTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                passTxt.Focus();
            }
        }

        private void passTxt_MouseEnter(object sender, EventArgs e)
        {
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginBtn_Click(sender, e);
            }
        }
    }
}

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
    public partial class SignupForm : Form
    {
        private string conString = "Server=127.0.0.1;database=translatify_db;user=root;";
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = true;
            conPass.UseSystemPasswordChar = true;
        }

        private void eye_CheckedChanged(object sender, EventArgs e)
        {
            if (eye.Checked)
            {
                passTxt.UseSystemPasswordChar = false;
            } else
            {
                passTxt.UseSystemPasswordChar= true;
            }
        }

        private void consEye_CheckedChanged(object sender, EventArgs e)
        {
            if (consEye.Checked)
            {
                conPass.UseSystemPasswordChar = false;
            }
            else
            {
                conPass.UseSystemPasswordChar = true;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userTxt.Text) || string.IsNullOrEmpty(passTxt.Text) || string.IsNullOrEmpty(conPass.Text))
            {
                MessageBox.Show("Please fill all the fields");

            }
            else if (passTxt.Text != conPass.Text)
            {
                MessageBox.Show("Passwords don't match");
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string qry = "INSERT INTO `users`(`id`, `username`, `password`) VALUES (?, ?, ?)";
                    using (MySqlCommand cmd = new MySqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("param1", null);
                        cmd.Parameters.AddWithValue("param2", userTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("param3", passTxt.Text.Trim());
                        int insert = cmd.ExecuteNonQuery();
                        if (insert > 0)
                        {
                            MessageBox.Show("Signed up Successfully");
                            MainForm main = new MainForm();
                            main.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Signed up Unsuccessfully");
                        }
                    }
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void userTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                passTxt.Focus();
            }
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                conPass.Focus();
            }
        }

        private void conPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginBtn_Click(sender, e);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Repairs_M_S
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data !!!");
            }
            else if (UserNameTb.Text == "ahmed" && PasswordTb.Text == "khaled")
            {
                Spares obj = new Spares();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Data");
            }
        }

        private void ResetLabel_Click(object sender, EventArgs e)
        {
            UserNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

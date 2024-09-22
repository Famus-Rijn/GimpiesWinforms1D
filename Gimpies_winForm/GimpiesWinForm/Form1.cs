using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GimpiesWinForm
{
    public partial class Form1 : Form
    {




        public static string VERKOOPNAME = "Verkoop";
        public static string VERKOOPPASSWORD = "Gimpies_Verkoop";
        public static string ADMINNAME = "Admin";
        public static string ADMINPASSWORD = "Gimpies_Admin";
        static public int AssignedLeveL = 0;
        static public int AssignedLevel; 
        public int LOGINATTEMPTS = 3;
        public int COUNTDOWN = 3000;
        public bool MessageBoxShown = false;






        public Form1()
        {
            InitializeComponent();
            username.Focus();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (username.Text == VERKOOPNAME && password.Text == VERKOOPPASSWORD)
            {
                LOGINATTEMPTS = 3;
                var f = new Menu();
                this.Hide();
                f.Show();
            }
            else if (username.Text == ADMINNAME && password.Text == ADMINPASSWORD)
            {
                LOGINATTEMPTS = 3;
                AssignedLeveL = 2;
                var f = new Menu();
                this.Hide();
                f.Show();
            }
            else
            {
                LOGINATTEMPTS--;
                MessageBox.Show("Invalid credentials, " + LOGINATTEMPTS + " log-in attempts left.");

                if (LOGINATTEMPTS == 0)
                {
                    MessageBox.Show($"Too many failed attempts, application will stop after this message is closed");
                    Application.Exit();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                return;
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                if (password.UseSystemPasswordChar == true)
                {
                    password.UseSystemPasswordChar = false;
                }
                else
                {
                    password.UseSystemPasswordChar = !false;
                }
            }

            private void ExitLabelText_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        private void ClearFieldsLabel_Click(object sender, EventArgs e)
        {
            password.Clear();
            username.Clear();
            username.Focus();
        }
    }
    }
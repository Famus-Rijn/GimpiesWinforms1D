using System;
using System.Net.Security;
using System.Windows.Forms;

namespace GimpiesWinForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //GreetingLabel.Text = ("Welcome User!"!  + " countdown");
        }

        bool MaximizedForm = false;
        string countdown = DateTime.Now.ToString();

        public int MenuLevel { get; }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            if (!MaximizedForm)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Activate(); // Ensure the form is activated
                MaximizedForm = true; // Set to true directly
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate(); // Ensure the form is activated
                MaximizedForm = false; // Set to false directly
            }
        }


        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void LOGOUTBUTTON_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            var f = new Form1();
            
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GreetingLabel_Click(object sender, System.EventArgs e)
        {
            return;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
    }
}

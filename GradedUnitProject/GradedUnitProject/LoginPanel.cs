using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedUnitProject
{
    public partial class LoginPanel : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        public LoginPanel()
        {
            InitializeComponent();

                
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkPassword()) { 
            this.Close();
            var thread = new Thread(runDashboard);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            }
           
        }

        private bool checkPassword()
        {
            var password = "";

            if (textBoxPassword.Text == password)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password incorrect");
                return false;
            }
        }

        private void runDashboard()
        {
            Application.Run(new Dashboard());
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLLogin.PerformClick();
            }
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            if(Program.debug)
            buttonLLogin.PerformClick();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

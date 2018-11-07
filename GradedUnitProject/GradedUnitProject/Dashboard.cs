using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedUnitProject
{
    public partial class Dashboard : Form, FormComunicatorInterface
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        public Dashboard()
        {
            InitializeComponent();
            attachFormToPanel(new DashboardWelcomeScreen());
            
        }

        public void test(Form x)
        {


            Form z = this.panelContext.Controls.OfType<Form>().First();
            z.Hide();
            this.panelContext.Controls.Add(x);


        }
        private void attachFormToPanel(object form)
        {
            if (this.panelContext.Controls.Count > 0)
                this.panelContext.Controls.RemoveAt(0);


            
            Form toAttachForm = form as Form;
            toAttachForm.TopLevel = false;
            toAttachForm.Dock = DockStyle.Fill;
            this.panelContext.Controls.Add(toAttachForm);
            toAttachForm.Show();

                                 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            minButton.Visible = true;
            maxButton.Visible = false;
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            minButton.Visible = false;
            maxButton.Visible = true;
        }

        private void trayButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            attachFormToPanel(new UserManage(this));
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if(this.WindowState == FormWindowState.Normal)
            {
                minButton.Visible = false;
                maxButton.Visible = true;
            }
        }

        private void close_Menu_Click(object sender, EventArgs e)
        {
            panelMenu.Width = panelMenu.Width - 166;
            closeMenuBox.Visible = false;
            openMenuBox.Visible = true;
            logoText.Visible = false;
        }

        private void open_Menu_Click(object sender, EventArgs e)
        {
            panelMenu.Width = panelMenu.Width + 166;
            closeMenuBox.Visible = true;
            openMenuBox.Visible = false;
            logoText.Visible = true;
        }

        public void OnFormClose()
        {
            attachFormToPanel(new DashboardWelcomeScreen());

        }

        public void OpenChildForm(Form toAttachForm)
        {
            
            toAttachForm.TopLevel = false;
            toAttachForm.Dock = DockStyle.Fill;
            this.panelContext.Controls.Add(toAttachForm);
            toAttachForm.Show();
        }
    }
}

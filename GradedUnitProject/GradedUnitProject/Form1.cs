using GradedUnitProject.Custom_Controls;
using System;
using System.Windows.Forms;

namespace GradedUnitProject
{
    public partial class Form1 : Form
    {
        Form parentContext = null;

        public Form1()
        {
            
        }

        public Form1(Form parentContext)
        {
            InitializeComponent();
            this.parentContext = parentContext;


            fillForm1.AddTextBox("name");
            fillForm1.AddTextBox("surname");
            fillForm1.AddTextBox("SRU");
            

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            parentContext.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void customHide()
        {
    


        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            DialogResult discardBox = MessageBox.Show("Do you want to discard all changes?", "Discard", MessageBoxButtons.YesNo);
            if (discardBox == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult discardBox = MessageBox.Show("Do you want to discard all changes?", "Discard", MessageBoxButtons.YesNo);
            if (discardBox == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            
        }
    }
}

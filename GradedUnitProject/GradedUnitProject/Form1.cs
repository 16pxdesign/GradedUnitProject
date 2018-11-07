using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            parentContext.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

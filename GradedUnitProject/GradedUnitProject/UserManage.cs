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
    public partial class UserManage : Form
    {
        Form parentContext;
        public UserManage(Form parent)
        {
            this.parentContext = parent;
            InitializeComponent();

        }

    

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
            if (parentContext is FormComunicatorInterface)
            {
                FormComunicatorInterface context = (FormComunicatorInterface)parentContext;
                context.OnFormClose();
            }
            else
            {
                throw new Exception("Need to implement FormComunicatorInterface to parent Form" + parentContext.GetType().ToString());
            }
        }
    }
}

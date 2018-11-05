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


        public async Task<DataTable> GetDataAsync()
        {
            
            DataTable table = null;
            MysqlContext mysql = new MysqlContext();
            
            await Task.Run(() => { table = mysql.getTable(); });
            return table;
        }

        private async Task BindDataToGridAsync()
        {

            try
            {
                var data = await GetDataAsync();

                
                this.customDataGrid51.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

            

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

        private void buttonUser_Click(object sender, EventArgs e)
        {
            if (parentContext is FormComunicatorInterface)
            {
                FormComunicatorInterface context = (FormComunicatorInterface)parentContext;
                var openingForm = (Form)new Form1(this);
                context.OpenChildForm(openingForm);
                this.Hide();
            }
            else
            {
                throw new Exception("Need to implement FormComunicatorInterface to parent Form" + parentContext.GetType().ToString());
            }

        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            //
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            BindDataToGridAsync();
        }
    }
}

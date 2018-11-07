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
            
            
            await Task.Run(() => {
              try
                {
                    MysqlContext mysql = new MysqlContext();
                    table = mysql.getTable();
                }
                catch (Exception e)
                {
                MessageBox.Show(e.Message.ToString());
                }
            });
            return table;
        }

      


        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
            if (parentContext is FormComunicatorInterface)
            {
                FormComunicatorInterface formComunicator = (FormComunicatorInterface)parentContext;
                formComunicator.OnFormClose();
            }
            else
            {
                throw new Exception("Need to implement FormComunicatorInterface to parent Form" + parentContext.GetType().ToString());
            }
        }

        private void openWindow_Click(object sender, EventArgs e)
        {
            if (parentContext is FormComunicatorInterface)
            {
                FormComunicatorInterface formComunicator = (FormComunicatorInterface)parentContext;
                var openingForm = (Form)new Form1(this);
                formComunicator.OpenChildForm(openingForm);
                this.Hide();
            }
            else
            {
                throw new Exception("Need to implement FormComunicatorInterface to parent Form" + parentContext.GetType().ToString());
            }

        }


        private async void BindDataToGridAsync()
        {

            var data = await GetDataAsync();

            this.customDataGrid51.DataSource = data;

            if (data != null)
            {
                foreach (Control item in this.Controls.OfType<Control>())
                {
                    if (item.Name == "circularProgressBar1")
                        this.Controls.Remove(item);
                }
            }
            else
            {
                circularProgressBar1.Text = "Error";
            }
           


        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            BindDataToGridAsync();
        }

    }
}

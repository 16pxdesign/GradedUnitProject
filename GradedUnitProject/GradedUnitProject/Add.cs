using GradedUnitProject.Custom_Controls;
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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

            CustomGeneratedFormBuilder generatedForm = CustomGeneratedFormBuilder.Create()
                .CreateFrame()
                .NewRow("Name")
                .NewItem()
                .NewRow("Name")
                .NewItem()
                .NewRow("Name")
                .NewItem()
                .NewRow("Name")
                .NewItem()
                .NewRow("Name")
                .NewItem()
                .NewRow("Name")
                .NewItem()
                .Build();
            generatedForm.Dock = DockStyle.Fill;
           this.Controls.Add(generatedForm);
           
        }
    }
}

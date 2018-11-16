using GradedUnitProject.Custom_Controls.IGeneratedForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedUnitProject.Custom_Controls
{
    public class CustomGeneratedFormBuilder : UserControl, ICustomGeneratedFormFrame, ICustomGeneratedFormRow, ICustomGeneratedFormItem

    {

        private System.Windows.Forms.TableLayoutPanel customContolPanel;
        private System.Windows.Forms.FlowLayoutPanel framePanel;
        private TableLayoutPanel row;
        private String rowName;
        private int itemsInRow;

        public CustomGeneratedFormBuilder()
        {
        }

        public static ICustomGeneratedFormFrame Create()
        {
            return new CustomGeneratedFormBuilder();
        }
        public CustomGeneratedFormBuilder Build()
        {
            this.Controls.Add(customContolPanel);
            return this;
        }

        public ICustomGeneratedFormRow CreateFrame()
        {
            this.customContolPanel = new System.Windows.Forms.TableLayoutPanel();
            this.framePanel = new System.Windows.Forms.FlowLayoutPanel();

            //custom
            this.customContolPanel.ColumnCount = 1;
            this.customContolPanel.RowCount = 1;
            this.customContolPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customContolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customContolPanel.Location = new System.Drawing.Point(0, 0);
            this.customContolPanel.Name = "customPanel";
            this.customContolPanel.BackColor = Color.Black;


            //framePanel
            this.framePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.framePanel.AutoSize = true;
            this.framePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.mainPanel.Dock = System.Windows.Forms.DockStyle.None;
            this.framePanel.Location = new System.Drawing.Point(0, 0);
            this.framePanel.Name = "framePanel";
            this.framePanel.BackColor = Color.Green;
            this.framePanel.Size = new Size(1, 1);
            this.customContolPanel.Controls.Add(this.framePanel, 0, 0);

            return this;
        }

        public ICustomGeneratedFormItem NewItem()
        {
            if (itemsInRow == 0)
            {
                itemsInRow = itemsInRow+1;
            }
            else
            {
                throw new Exception("Only one item per row");
            }
            

            AddTextbox();

            return this;
        }

        public ICustomGeneratedFormItem NewRow(String name)
        {
            itemsInRow = 0;
            this.row = new TableLayoutPanel();
            this.rowName = name;

            if(framePanel.Controls.Count > 0)
            {
                //Brake line label
                Label brakeLineLabel = new Label();
                brakeLineLabel.Width = 0;
                brakeLineLabel.Height = 0;
                brakeLineLabel.Margin = new Padding(0, 0, 0, 0);
                framePanel.Controls.Add(brakeLineLabel);
                framePanel.SetFlowBreak(brakeLineLabel, true);
            }

            //row
            row.AutoSize = true;
            row.ColumnCount = 2;
            row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            row.Location = new System.Drawing.Point(3, 3);
            row.Name = "rowPanel" + rowName;
            row.RowCount = 1;
            row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            row.BackColor = Color.Yellow;
            framePanel.Controls.Add(row);
            AddLabel();
            return this;
        }

        private void AddLabel()
        {
            //label
            Label label = new Label();
            //labelName.AutoSize = true;
            label.Anchor = AnchorStyles.None;
            label.ForeColor = System.Drawing.Color.White;
            label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(3, 11);
            label.Name = "label" + rowName;
            label.Size = new System.Drawing.Size(70, 30);
            label.TabIndex = 0;
//TODO: Chane Label description
            label.Text = rowName;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            row.Controls.Add(label, 0, 0);
        }

        private void AddTextbox()
        {
            //Textbox
            TextBox textBox = new TextBox();
            textBox.Anchor = AnchorStyles.None;
            textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.Location = new System.Drawing.Point(103, 43);
            textBox.Name = "textBox" + rowName;
            textBox.Size = new System.Drawing.Size(200, 27);
            row.Controls.Add(textBox, 1, 0);
        }

        public Boolean GetValue(String name)
        {

            var x = "rowPanel" + name;
            var y = "rowPanel";
            foreach (Control c in framePanel.Controls)
            {
                if (c.Name.Equals(x))
                {

                    foreach (Control d in c.Controls)
                    {
                        MessageBox.Show(d.Name);

                    }

                    return true;
                }

                MessageBox.Show(c.Name);

            }
            return false;
        }
    }
 
}

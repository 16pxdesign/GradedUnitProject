using WinFormAnimation;

namespace GradedUnitProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customDataGrid61 = new GradedUnitProject.CustomDataGrid6();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid61)).BeginInit();
            this.SuspendLayout();
            // 
            // customDataGrid61
            // 
            this.customDataGrid61.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGrid61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGrid61.Location = new System.Drawing.Point(84, 51);
            this.customDataGrid61.Name = "customDataGrid61";
            this.customDataGrid61.Size = new System.Drawing.Size(240, 150);
            this.customDataGrid61.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customDataGrid61);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid61)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid6 customDataGrid61;
    }
}
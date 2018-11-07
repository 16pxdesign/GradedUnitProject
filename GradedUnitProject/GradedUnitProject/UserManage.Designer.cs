namespace GradedUnitProject
{
    partial class UserManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManage));
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.buttonUser = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.customDataGrid51 = new GradedUnitProject.CustomDataGrid6();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid51)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.Image = ((System.Drawing.Image)(resources.GetObject("closeBox.Image")));
            this.closeBox.Location = new System.Drawing.Point(516, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 0;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(80)))));
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonUser.Image")));
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(12, 12);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonUser.Size = new System.Drawing.Size(80, 31);
            this.buttonUser.TabIndex = 2;
            this.buttonUser.Text = "New";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.openWindow_Click);
            // 
            // customDataGrid51
            // 
            this.customDataGrid51.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customDataGrid51.Location = new System.Drawing.Point(26, 114);
            this.customDataGrid51.Name = "customDataGrid51";
            this.customDataGrid51.Size = new System.Drawing.Size(498, 258);
            this.customDataGrid51.TabIndex = 3;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.circularProgressBar1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.AppWorkspace;
            this.circularProgressBar1.InnerMargin = 0;
            this.circularProgressBar1.InnerWidth = 0;
            this.circularProgressBar1.Location = new System.Drawing.Point(215, 185);
            this.circularProgressBar1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar1.OuterMargin = -11;
            this.circularProgressBar1.OuterWidth = 8;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.circularProgressBar1.ProgressWidth = 14;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(120, 120);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.Text = "Loading";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.circularProgressBar1.Value = 50;
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(548, 384);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.customDataGrid51);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.closeBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManage";
            this.Text = "UserManage";
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid51)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.Button buttonUser;
        private CustomDataGrid6 customDataGrid51;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}
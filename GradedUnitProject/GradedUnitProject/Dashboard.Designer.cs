namespace GradedUnitProject
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.topBar = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.PictureBox();
            this.maxButton = new System.Windows.Forms.PictureBox();
            this.trayButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logoText = new System.Windows.Forms.Label();
            this.openMenuBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.closeMenuBox = new System.Windows.Forms.PictureBox();
            this.panelContext = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openMenuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeMenuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(164)))));
            this.topBar.Controls.Add(this.minButton);
            this.topBar.Controls.Add(this.maxButton);
            this.topBar.Controls.Add(this.trayButton);
            this.topBar.Controls.Add(this.exitButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1000, 30);
            this.topBar.TabIndex = 1;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.Location = new System.Drawing.Point(948, 7);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(20, 20);
            this.minButton.TabIndex = 2;
            this.minButton.TabStop = false;
            this.minButton.Visible = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxButton.Image = ((System.Drawing.Image)(resources.GetObject("maxButton.Image")));
            this.maxButton.Location = new System.Drawing.Point(948, 7);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(20, 20);
            this.maxButton.TabIndex = 2;
            this.maxButton.TabStop = false;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // trayButton
            // 
            this.trayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trayButton.Image = ((System.Drawing.Image)(resources.GetObject("trayButton.Image")));
            this.trayButton.Location = new System.Drawing.Point(922, 7);
            this.trayButton.Name = "trayButton";
            this.trayButton.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.trayButton.Size = new System.Drawing.Size(20, 20);
            this.trayButton.TabIndex = 0;
            this.trayButton.TabStop = false;
            this.trayButton.Click += new System.EventHandler(this.trayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(974, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.panelMenu.Controls.Add(this.logoText);
            this.panelMenu.Controls.Add(this.openMenuBox);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.buttonUser);
            this.panelMenu.Controls.Add(this.closeMenuBox);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(216, 470);
            this.panelMenu.TabIndex = 2;
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoText.ForeColor = System.Drawing.Color.White;
            this.logoText.Location = new System.Drawing.Point(12, 20);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(125, 18);
            this.logoText.TabIndex = 0;
            this.logoText.Text = "Simply Rugby";
            // 
            // openMenuBox
            // 
            this.openMenuBox.Image = ((System.Drawing.Image)(resources.GetObject("openMenuBox.Image")));
            this.openMenuBox.Location = new System.Drawing.Point(5, 6);
            this.openMenuBox.Name = "openMenuBox";
            this.openMenuBox.Size = new System.Drawing.Size(40, 40);
            this.openMenuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.openMenuBox.TabIndex = 4;
            this.openMenuBox.TabStop = false;
            this.openMenuBox.Visible = false;
            this.openMenuBox.Click += new System.EventHandler(this.open_Menu_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(80)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 191);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(216, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Player Evaluation";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(80)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 148);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(216, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Game Management";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 105);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(216, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Training Management";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(80)))));
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonUser.Image")));
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(0, 62);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonUser.Size = new System.Drawing.Size(216, 36);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "User Management";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // closeMenuBox
            // 
            this.closeMenuBox.Image = ((System.Drawing.Image)(resources.GetObject("closeMenuBox.Image")));
            this.closeMenuBox.Location = new System.Drawing.Point(170, 6);
            this.closeMenuBox.Name = "closeMenuBox";
            this.closeMenuBox.Size = new System.Drawing.Size(40, 40);
            this.closeMenuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeMenuBox.TabIndex = 0;
            this.closeMenuBox.TabStop = false;
            this.closeMenuBox.Click += new System.EventHandler(this.close_Menu_Click);
            // 
            // panelContext
            // 
            this.panelContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContext.Location = new System.Drawing.Point(216, 30);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(784, 470);
            this.panelContext.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.topBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openMenuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeMenuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox trayButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minButton;
        private System.Windows.Forms.PictureBox maxButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContext;
        private System.Windows.Forms.PictureBox closeMenuBox;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox openMenuBox;
        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
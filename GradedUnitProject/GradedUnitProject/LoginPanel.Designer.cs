namespace GradedUnitProject
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.topBar = new System.Windows.Forms.Panel();
            this.trayButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLLogin = new System.Windows.Forms.Button();
            this.labelWelcomeText = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(164)))));
            this.topBar.Controls.Add(this.trayButton);
            this.topBar.Controls.Add(this.exitButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(400, 30);
            this.topBar.TabIndex = 0;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // trayButton
            // 
            this.trayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trayButton.Image = ((System.Drawing.Image)(resources.GetObject("trayButton.Image")));
            this.trayButton.Location = new System.Drawing.Point(348, 6);
            this.trayButton.Name = "trayButton";
            this.trayButton.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.trayButton.Size = new System.Drawing.Size(20, 20);
            this.trayButton.TabIndex = 0;
            this.trayButton.TabStop = false;
            this.trayButton.Click += new System.EventHandler(this.minimalize_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(374, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.labelPassword);
            this.mainPanel.Controls.Add(this.textBoxPassword);
            this.mainPanel.Controls.Add(this.buttonLLogin);
            this.mainPanel.Controls.Add(this.labelWelcomeText);
            this.mainPanel.Dock = (System.Windows.Forms.DockStyle.Fill);
            this.mainPanel.ForeColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 200);
            this.mainPanel.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(164, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(96, 79);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(207, 23);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonLLogin
            // 
            this.buttonLLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLLogin.AutoSize = true;
            this.buttonLLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(164)))));
            this.buttonLLogin.FlatAppearance.BorderSize = 0;
            this.buttonLLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLLogin.Location = new System.Drawing.Point(167, 121);
            this.buttonLLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLLogin.Name = "buttonLLogin";
            this.buttonLLogin.Size = new System.Drawing.Size(64, 26);
            this.buttonLLogin.TabIndex = 1;
            this.buttonLLogin.Text = "Sign In";
            this.buttonLLogin.UseVisualStyleBackColor = false;
            this.buttonLLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWelcomeText
            // 
            this.labelWelcomeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcomeText.AutoSize = true;
            this.labelWelcomeText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeText.ForeColor = System.Drawing.Color.Black;
            this.labelWelcomeText.Location = new System.Drawing.Point(94, 25);
            this.labelWelcomeText.Name = "labelWelcomeText";
            this.labelWelcomeText.Size = new System.Drawing.Size(210, 18);
            this.labelWelcomeText.TabIndex = 0;
            this.labelWelcomeText.Text = "Sign in to Simply Rugby";
            this.labelWelcomeText.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            this.topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox trayButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelWelcomeText;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLLogin;
    }
}


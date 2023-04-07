namespace zakat_fitrah
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_username
            // 
            this.textbox_username.AllowDrop = true;
            this.textbox_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_username.CausesValidation = false;
            this.textbox_username.Location = new System.Drawing.Point(101, 70);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(212, 26);
            this.textbox_username.TabIndex = 0;
            this.textbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_username.UseWaitCursor = true;
            this.textbox_username.TextChanged += new System.EventHandler(this.textbok_username_TextChanged);
            // 
            // textbox_password
            // 
            this.textbox_password.AllowDrop = true;
            this.textbox_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_password.CausesValidation = false;
            this.textbox_password.Location = new System.Drawing.Point(101, 118);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(212, 26);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_password.UseWaitCursor = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))));
            this.button_login.Location = new System.Drawing.Point(173, 163);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(84, 38);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 303);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_username);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_login;
    }
}
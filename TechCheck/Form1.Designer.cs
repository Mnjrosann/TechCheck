namespace TechCheck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(589, 188);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(110, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(589, 231);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(110, 23);
            txtPass.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(606, 270);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 22);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 555);
            Controls.Add(btnLogin);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button button1;
        private Button btnLogin;
    }
}

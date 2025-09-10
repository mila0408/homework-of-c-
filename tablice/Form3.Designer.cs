namespace tablice
{
    partial class Form3
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
            deleteUser = new Button();
            deleteLogin = new TextBox();
            loginF3 = new Label();
            SuspendLayout();
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(376, 227);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(118, 50);
            deleteUser.TabIndex = 0;
            deleteUser.Text = "delet";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += DeletUserF3;
            // 
            // deleteLogin
            // 
            deleteLogin.Location = new Point(367, 169);
            deleteLogin.Name = "deleteLogin";
            deleteLogin.Size = new Size(140, 23);
            deleteLogin.TabIndex = 1;
            // 
            // loginF3
            // 
            loginF3.AutoSize = true;
            loginF3.Location = new Point(297, 172);
            loginF3.Name = "loginF3";
            loginF3.Size = new Size(34, 15);
            loginF3.TabIndex = 2;
            loginF3.Text = "login";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginF3);
            Controls.Add(deleteLogin);
            Controls.Add(deleteUser);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteUser;
        private TextBox deleteLogin;
        private Label loginF3;
    }
}
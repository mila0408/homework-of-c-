namespace tablice
{
    partial class Form2
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
            loginText = new TextBox();
            passwordText = new TextBox();
            nameText = new TextBox();
            ageText = new TextBox();
            login = new Label();
            password = new Label();
            name = new Label();
            age = new Label();
            text = new Label();
            add = new Button();
            SuspendLayout();
            // 
            // loginText
            // 
            loginText.Location = new Point(329, 55);
            loginText.Name = "loginText";
            loginText.Size = new Size(151, 23);
            loginText.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(329, 119);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(151, 23);
            passwordText.TabIndex = 1;
            // 
            // nameText
            // 
            nameText.Location = new Point(329, 183);
            nameText.Name = "nameText";
            nameText.Size = new Size(151, 23);
            nameText.TabIndex = 2;
            // 
            // ageText
            // 
            ageText.Location = new Point(329, 244);
            ageText.Name = "ageText";
            ageText.Size = new Size(100, 23);
            ageText.TabIndex = 3;
            ageText.TextChanged += textBox4_TextChanged;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(232, 58);
            login.Name = "login";
            login.Size = new Size(34, 15);
            login.TabIndex = 4;
            login.Text = "login";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(232, 119);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 5;
            password.Text = "password";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(232, 186);
            name.Name = "name";
            name.Size = new Size(37, 15);
            name.TabIndex = 6;
            name.Text = "name";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(232, 247);
            age.Name = "age";
            age.Size = new Size(26, 15);
            age.TabIndex = 7;
            age.Text = "age";
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(263, 9);
            text.Name = "text";
            text.Size = new Size(27, 15);
            text.TabIndex = 8;
            text.Text = "text";
            // 
            // add
            // 
            add.Location = new Point(345, 301);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 9;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += addUsers;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add);
            Controls.Add(text);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(ageText);
            Controls.Add(nameText);
            Controls.Add(passwordText);
            Controls.Add(loginText);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginText;
        private TextBox passwordText;
        private TextBox nameText;
        private TextBox ageText;
        private Label login;
        private Label password;
        private Label name;
        private Label age;
        private Label text;
        private Button add;
    }
}
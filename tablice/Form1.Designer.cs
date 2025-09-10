namespace tablice
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
            dataGridView1 = new DataGridView();
            addUser = new Button();
            deleteUser = new Button();
            import = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 426);
            dataGridView1.TabIndex = 0;
            // 
            // addUser
            // 
            addUser.Location = new Point(564, 96);
            addUser.Name = "addUser";
            addUser.Size = new Size(75, 23);
            addUser.TabIndex = 1;
            addUser.Text = "addUser";
            addUser.UseVisualStyleBackColor = true;
            addUser.Click += add_User;
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(564, 202);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(75, 23);
            deleteUser.TabIndex = 2;
            deleteUser.Text = "deleteUser";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += delete_User;
            // 
            // import
            // 
            import.Location = new Point(564, 293);
            import.Name = "import";
            import.Size = new Size(75, 23);
            import.TabIndex = 3;
            import.Text = "import";
            import.UseVisualStyleBackColor = true;
            import.Click += importBD;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(import);
            Controls.Add(deleteUser);
            Controls.Add(addUser);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Click += o;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button deleteUser;
        private Button addUser;
        private Button import;
    }
}

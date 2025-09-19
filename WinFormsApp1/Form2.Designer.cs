namespace WinFormsApp1
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
            test1 = new Button();
            test2 = new Button();
            test3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // test1
            // 
            test1.Location = new Point(219, 83);
            test1.Name = "test1";
            test1.Size = new Size(75, 23);
            test1.TabIndex = 0;
            test1.Text = "test1";
            test1.UseVisualStyleBackColor = true;
            test1.Click += test1Click;
            // 
            // test2
            // 
            test2.Location = new Point(359, 83);
            test2.Name = "test2";
            test2.Size = new Size(75, 23);
            test2.TabIndex = 1;
            test2.Text = "test2";
            test2.UseVisualStyleBackColor = true;
            test2.Click += test2Click;
            // 
            // test3
            // 
            test3.Location = new Point(527, 83);
            test3.Name = "test3";
            test3.Size = new Size(75, 23);
            test3.TabIndex = 2;
            test3.Text = "test3";
            test3.UseVisualStyleBackColor = true;
            test3.Click += test3Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(test3);
            Controls.Add(test2);
            Controls.Add(test1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button test2;
        private Button test3;
        private Label label1;
        private Button test1;
    }
}
namespace PSbFM
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
            addExpense = new Button();
            SummaExpense = new Label();
            SpentOnF2 = new Label();
            CategoryExpense = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            CategoryIncome = new Label();
            CamrFromF2 = new Label();
            SummaIncome = new Label();
            AddIncome = new Button();
            Massege = new Label();
            dateTimeExpense = new DateTimePicker();
            dateTimeIncome = new DateTimePicker();
            domainUpDown1 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            SuspendLayout();
            // 
            // addExpense
            // 
            addExpense.Location = new Point(250, 202);
            addExpense.Name = "addExpense";
            addExpense.Size = new Size(137, 48);
            addExpense.TabIndex = 1;
            addExpense.Text = "Add expense to the list";
            addExpense.UseVisualStyleBackColor = true;
            addExpense.Click += addExpenseClick;
            // 
            // SummaExpense
            // 
            SummaExpense.AutoSize = true;
            SummaExpense.Location = new Point(179, 35);
            SummaExpense.Name = "SummaExpense";
            SummaExpense.Size = new Size(48, 15);
            SummaExpense.TabIndex = 2;
            SummaExpense.Text = "Summa";
            // 
            // SpentOnF2
            // 
            SpentOnF2.AutoSize = true;
            SpentOnF2.Location = new Point(179, 75);
            SpentOnF2.Name = "SpentOnF2";
            SpentOnF2.Size = new Size(54, 15);
            SpentOnF2.TabIndex = 3;
            SpentOnF2.Text = "Spent on";
            // 
            // CategoryExpense
            // 
            CategoryExpense.AutoSize = true;
            CategoryExpense.Location = new Point(172, 117);
            CategoryExpense.Name = "CategoryExpense";
            CategoryExpense.Size = new Size(55, 15);
            CategoryExpense.TabIndex = 5;
            CategoryExpense.Text = "Category";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(543, 75);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(543, 32);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 17;
            // 
            // CategoryIncome
            // 
            CategoryIncome.AutoSize = true;
            CategoryIncome.Location = new Point(472, 117);
            CategoryIncome.Name = "CategoryIncome";
            CategoryIncome.Size = new Size(55, 15);
            CategoryIncome.TabIndex = 16;
            CategoryIncome.Text = "Category";
            // 
            // CamrFromF2
            // 
            CamrFromF2.AutoSize = true;
            CamrFromF2.Location = new Point(460, 75);
            CamrFromF2.Name = "CamrFromF2";
            CamrFromF2.Size = new Size(67, 15);
            CamrFromF2.TabIndex = 14;
            CamrFromF2.Text = "Came from";
            // 
            // SummaIncome
            // 
            SummaIncome.AutoSize = true;
            SummaIncome.Location = new Point(479, 35);
            SummaIncome.Name = "SummaIncome";
            SummaIncome.Size = new Size(48, 15);
            SummaIncome.TabIndex = 13;
            SummaIncome.Text = "Summa";
            // 
            // AddIncome
            // 
            AddIncome.Location = new Point(545, 202);
            AddIncome.Name = "AddIncome";
            AddIncome.Size = new Size(137, 48);
            AddIncome.TabIndex = 12;
            AddIncome.Text = "Add income to the list";
            AddIncome.UseVisualStyleBackColor = true;
            AddIncome.Click += AddIncomeClick;
            // 
            // Massege
            // 
            Massege.AutoSize = true;
            Massege.Location = new Point(419, 285);
            Massege.Name = "Massege";
            Massege.Size = new Size(53, 15);
            Massege.TabIndex = 21;
            Massege.Text = "massage";
            // 
            // dateTimeExpense
            // 
            dateTimeExpense.Location = new Point(250, 155);
            dateTimeExpense.Name = "dateTimeExpense";
            dateTimeExpense.Size = new Size(200, 23);
            dateTimeExpense.TabIndex = 22;
            // 
            // dateTimeIncome
            // 
            dateTimeIncome.Location = new Point(543, 155);
            dateTimeIncome.Name = "dateTimeIncome";
            dateTimeIncome.Size = new Size(200, 23);
            dateTimeIncome.TabIndex = 23;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(250, 115);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(137, 23);
            domainUpDown1.TabIndex = 24;
            domainUpDown1.Text = "domainUpDown1";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(543, 115);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(139, 23);
            domainUpDown2.TabIndex = 25;
            domainUpDown2.Text = "domainUpDown2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 552);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(dateTimeIncome);
            Controls.Add(dateTimeExpense);
            Controls.Add(Massege);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(CategoryIncome);
            Controls.Add(CamrFromF2);
            Controls.Add(SummaIncome);
            Controls.Add(AddIncome);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CategoryExpense);
            Controls.Add(SpentOnF2);
            Controls.Add(SummaExpense);
            Controls.Add(addExpense);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SummaExpense;
        private Label SpentOnF2;
        private Label CategoryExpense;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label CategoryIncome;
        private Label CamrFromF2;
        private Label SummaIncome;
        private Button AddIncome;
        private Label Massege;
        private Button addExpense;
        private DateTimePicker dateTimeExpense;
        private DateTimePicker dateTimeIncome;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
    }
}
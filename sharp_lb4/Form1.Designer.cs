namespace sharp_lb4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridPartBooks = new System.Windows.Forms.DataGridView();
            this.allBooksGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorRegister = new System.Windows.Forms.Button();
            this.DeleteAuthor = new System.Windows.Forms.Button();
            this.changeSelected = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeBook = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SortBooks = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.createPUB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(124, 96);
            this.dataGridAuthors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.ReadOnly = true;
            this.dataGridAuthors.RowHeadersWidth = 51;
            this.dataGridAuthors.RowTemplate.Height = 24;
            this.dataGridAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAuthors.Size = new System.Drawing.Size(344, 542);
            this.dataGridAuthors.TabIndex = 0;
            this.dataGridAuthors.CurrentCellChanged += new System.EventHandler(this.dataGridAuthors_CurrentCellChanged);
            // 
            // dataGridPartBooks
            // 
            this.dataGridPartBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartBooks.Location = new System.Drawing.Point(586, 96);
            this.dataGridPartBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridPartBooks.Name = "dataGridPartBooks";
            this.dataGridPartBooks.ReadOnly = true;
            this.dataGridPartBooks.RowHeadersWidth = 51;
            this.dataGridPartBooks.RowTemplate.Height = 24;
            this.dataGridPartBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartBooks.Size = new System.Drawing.Size(344, 542);
            this.dataGridPartBooks.TabIndex = 1;
            // 
            // allBooksGrid
            // 
            this.allBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooksGrid.Location = new System.Drawing.Point(952, 96);
            this.allBooksGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allBooksGrid.Name = "allBooksGrid";
            this.allBooksGrid.ReadOnly = true;
            this.allBooksGrid.RowHeadersWidth = 51;
            this.allBooksGrid.RowTemplate.Height = 24;
            this.allBooksGrid.Size = new System.Drawing.Size(360, 381);
            this.allBooksGrid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "author`s books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(948, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "all books";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1335, 96);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(344, 381);
            this.dataGridView4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1332, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "publishing houses";
            // 
            // AuthorRegister
            // 
            this.AuthorRegister.Location = new System.Drawing.Point(6, 9);
            this.AuthorRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthorRegister.Name = "AuthorRegister";
            this.AuthorRegister.Size = new System.Drawing.Size(100, 65);
            this.AuthorRegister.TabIndex = 0;
            this.AuthorRegister.Text = "Register author";
            this.AuthorRegister.UseVisualStyleBackColor = true;
            this.AuthorRegister.Click += new System.EventHandler(this.AuthorRegister_Click);
            // 
            // DeleteAuthor
            // 
            this.DeleteAuthor.Location = new System.Drawing.Point(7, 81);
            this.DeleteAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteAuthor.Name = "DeleteAuthor";
            this.DeleteAuthor.Size = new System.Drawing.Size(99, 64);
            this.DeleteAuthor.TabIndex = 1;
            this.DeleteAuthor.Text = "Delete selected";
            this.DeleteAuthor.UseVisualStyleBackColor = true;
            this.DeleteAuthor.Click += new System.EventHandler(this.DeleteAuthor_Click);
            // 
            // changeSelected
            // 
            this.changeSelected.Location = new System.Drawing.Point(6, 152);
            this.changeSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeSelected.Name = "changeSelected";
            this.changeSelected.Size = new System.Drawing.Size(100, 71);
            this.changeSelected.TabIndex = 2;
            this.changeSelected.Text = "Change selected";
            this.changeSelected.UseVisualStyleBackColor = true;
            this.changeSelected.Click += new System.EventHandler(this.changeSelected_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeSelected);
            this.panel1.Controls.Add(this.DeleteAuthor);
            this.panel1.Controls.Add(this.AuthorRegister);
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 300);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.changeBook);
            this.panel2.Controls.Add(this.deleteBook);
            this.panel2.Controls.Add(this.addBook);
            this.panel2.Location = new System.Drawing.Point(475, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 300);
            this.panel2.TabIndex = 9;
            // 
            // changeBook
            // 
            this.changeBook.Location = new System.Drawing.Point(7, 152);
            this.changeBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeBook.Name = "changeBook";
            this.changeBook.Size = new System.Drawing.Size(100, 65);
            this.changeBook.TabIndex = 3;
            this.changeBook.Text = "Change selected";
            this.changeBook.UseVisualStyleBackColor = true;
            this.changeBook.Click += new System.EventHandler(this.changeBook_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(7, 81);
            this.deleteBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(100, 65);
            this.deleteBook.TabIndex = 2;
            this.deleteBook.Text = "Delete selected";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(7, 9);
            this.addBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(100, 65);
            this.addBook.TabIndex = 1;
            this.addBook.Text = "Add book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1189, 504);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "By publishing";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1189, 536);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "By author";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1189, 569);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 24);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "By name";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1189, 601);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(87, 24);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "By year";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // SortBooks
            // 
            this.SortBooks.Location = new System.Drawing.Point(952, 499);
            this.SortBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortBooks.Name = "SortBooks";
            this.SortBooks.Size = new System.Drawing.Size(231, 140);
            this.SortBooks.TabIndex = 14;
            this.SortBooks.Text = "Sort";
            this.SortBooks.UseVisualStyleBackColor = true;
            this.SortBooks.Click += new System.EventHandler(this.SortBooks_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(20, 650);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(910, 171);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save all";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(952, 646);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(728, 175);
            this.LoadButton.TabIndex = 16;
            this.LoadButton.Text = "Load from disc";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // createPUB
            // 
            this.createPUB.Location = new System.Drawing.Point(1335, 536);
            this.createPUB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createPUB.Name = "createPUB";
            this.createPUB.Size = new System.Drawing.Size(84, 29);
            this.createPUB.TabIndex = 17;
            this.createPUB.Text = "create";
            this.createPUB.UseVisualStyleBackColor = true;
            this.createPUB.Click += new System.EventHandler(this.createPUB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1459, 532);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1335, 499);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 26);
            this.textBox2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 836);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createPUB);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SortBooks);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridPartBooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridAuthors);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allBooksGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.DataGridView dataGridPartBooks;
        private System.Windows.Forms.DataGridView allBooksGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AuthorRegister;
        private System.Windows.Forms.Button DeleteAuthor;
        private System.Windows.Forms.Button changeSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changeBook;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button SortBooks;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button createPUB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
    }
}


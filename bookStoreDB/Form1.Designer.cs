﻿namespace bookStoreDB
{
    partial class Form1
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
            this.booksInfoView = new System.Windows.Forms.DataGridView();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.button_filter = new System.Windows.Forms.Button();
            this.label_price = new System.Windows.Forms.Label();
            this.label_pages = new System.Windows.Forms.Label();
            this.numericUpDown_minPrice = new System.Windows.Forms.NumericUpDown();
            this.label_minPrice = new System.Windows.Forms.Label();
            this.label_maxPrice = new System.Windows.Forms.Label();
            this.numericUpDown_maxPrice = new System.Windows.Forms.NumericUpDown();
            this.label_minPages = new System.Windows.Forms.Label();
            this.numericUpDown_minPages = new System.Windows.Forms.NumericUpDown();
            this.label_maxPages = new System.Windows.Forms.Label();
            this.numericUpDown_maxPages = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.booksInfoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPages)).BeginInit();
            this.SuspendLayout();
            // 
            // booksInfoView
            // 
            this.booksInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksInfoView.Location = new System.Drawing.Point(12, 264);
            this.booksInfoView.Name = "booksInfoView";
            this.booksInfoView.RowTemplate.Height = 24;
            this.booksInfoView.Size = new System.Drawing.Size(674, 391);
            this.booksInfoView.TabIndex = 0;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(12, 57);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(271, 22);
            this.textBox_title.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.Location = new System.Drawing.Point(12, 35);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(220, 19);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Название книги";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(316, 57);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(277, 22);
            this.textBox_author.TabIndex = 3;
            // 
            // label_author
            // 
            this.label_author.Location = new System.Drawing.Point(316, 35);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(214, 19);
            this.label_author.TabIndex = 4;
            this.label_author.Text = "Автор";
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(692, 12);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(121, 347);
            this.button_filter.TabIndex = 5;
            this.button_filter.Text = "применить фильтр";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // label_price
            // 
            this.label_price.Location = new System.Drawing.Point(17, 98);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(204, 16);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Цена книги";
            // 
            // label_pages
            // 
            this.label_pages.Location = new System.Drawing.Point(17, 165);
            this.label_pages.Name = "label_pages";
            this.label_pages.Size = new System.Drawing.Size(164, 19);
            this.label_pages.TabIndex = 7;
            this.label_pages.Text = "Количество страниц";
            // 
            // numericUpDown_minPrice
            // 
            this.numericUpDown_minPrice.Location = new System.Drawing.Point(63, 126);
            this.numericUpDown_minPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_minPrice.Name = "numericUpDown_minPrice";
            this.numericUpDown_minPrice.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_minPrice.TabIndex = 8;
            // 
            // label_minPrice
            // 
            this.label_minPrice.Location = new System.Drawing.Point(25, 126);
            this.label_minPrice.Name = "label_minPrice";
            this.label_minPrice.Size = new System.Drawing.Size(32, 22);
            this.label_minPrice.TabIndex = 9;
            this.label_minPrice.Text = "от:";
            // 
            // label_maxPrice
            // 
            this.label_maxPrice.Location = new System.Drawing.Point(143, 126);
            this.label_maxPrice.Name = "label_maxPrice";
            this.label_maxPrice.Size = new System.Drawing.Size(29, 22);
            this.label_maxPrice.TabIndex = 10;
            this.label_maxPrice.Text = "до:";
            // 
            // numericUpDown_maxPrice
            // 
            this.numericUpDown_maxPrice.Location = new System.Drawing.Point(178, 126);
            this.numericUpDown_maxPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_maxPrice.Name = "numericUpDown_maxPrice";
            this.numericUpDown_maxPrice.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_maxPrice.TabIndex = 11;
            this.numericUpDown_maxPrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label_minPages
            // 
            this.label_minPages.Location = new System.Drawing.Point(25, 202);
            this.label_minPages.Name = "label_minPages";
            this.label_minPages.Size = new System.Drawing.Size(28, 22);
            this.label_minPages.TabIndex = 12;
            this.label_minPages.Text = "от:";
            // 
            // numericUpDown_minPages
            // 
            this.numericUpDown_minPages.Location = new System.Drawing.Point(63, 202);
            this.numericUpDown_minPages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_minPages.Name = "numericUpDown_minPages";
            this.numericUpDown_minPages.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_minPages.TabIndex = 13;
            // 
            // label_maxPages
            // 
            this.label_maxPages.Location = new System.Drawing.Point(143, 201);
            this.label_maxPages.Name = "label_maxPages";
            this.label_maxPages.Size = new System.Drawing.Size(32, 22);
            this.label_maxPages.TabIndex = 14;
            this.label_maxPages.Text = "до:";
            // 
            // numericUpDown_maxPages
            // 
            this.numericUpDown_maxPages.Location = new System.Drawing.Point(178, 199);
            this.numericUpDown_maxPages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_maxPages.Name = "numericUpDown_maxPages";
            this.numericUpDown_maxPages.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_maxPages.TabIndex = 15;
            this.numericUpDown_maxPages.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 667);
            this.Controls.Add(this.numericUpDown_maxPages);
            this.Controls.Add(this.label_maxPages);
            this.Controls.Add(this.numericUpDown_minPages);
            this.Controls.Add(this.label_minPages);
            this.Controls.Add(this.numericUpDown_maxPrice);
            this.Controls.Add(this.label_maxPrice);
            this.Controls.Add(this.label_minPrice);
            this.Controls.Add(this.numericUpDown_minPrice);
            this.Controls.Add(this.label_pages);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.booksInfoView);
            this.Name = "Form1";
            this.Text = "bookStoreDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksInfoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numericUpDown_minPrice;
        private System.Windows.Forms.Label label_minPrice;
        private System.Windows.Forms.Label label_maxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxPrice;
        private System.Windows.Forms.Label label_minPages;
        private System.Windows.Forms.NumericUpDown numericUpDown_minPages;
        private System.Windows.Forms.Label label_maxPages;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxPages;

        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_pages;

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Button button_filter;

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_author;

        private System.Windows.Forms.DataGridView booksInfoView;

        #endregion
    }
}
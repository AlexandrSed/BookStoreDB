namespace bookStoreDB
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
            ((System.ComponentModel.ISupportInitialize)(this.booksInfoView)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 667);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Button button_filter;

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_author;

        private System.Windows.Forms.DataGridView booksInfoView;

        #endregion
    }
}
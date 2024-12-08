using System.ComponentModel;

namespace bookStoreDB
{
    partial class NewBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_genre = new System.Windows.Forms.Label();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.label_ageLimit = new System.Windows.Forms.Label();
            this.comboBox_ageLimit = new System.Windows.Forms.ComboBox();
            this.label_price = new System.Windows.Forms.Label();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.label_pages = new System.Windows.Forms.Label();
            this.numericUpDown_pages = new System.Windows.Forms.NumericUpDown();
            this.label_yearOfPubl = new System.Windows.Forms.Label();
            this.numericUpDown_yaerOfPubl = new System.Windows.Forms.NumericUpDown();
            this.label_publisher = new System.Windows.Forms.Label();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.button_create = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.label_ageLimErr = new System.Windows.Forms.Label();
            this.label_titleErr = new System.Windows.Forms.Label();
            this.label_genreErr = new System.Windows.Forms.Label();
            this.label_authErr = new System.Windows.Forms.Label();
            this.label_PublErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yaerOfPubl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Location = new System.Drawing.Point(25, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(91, 21);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Название:";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(22, 46);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(250, 22);
            this.textBox_title.TabIndex = 1;
            // 
            // label_author
            // 
            this.label_author.Location = new System.Drawing.Point(348, 22);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(100, 23);
            this.label_author.TabIndex = 2;
            this.label_author.Text = "Автор:";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(348, 46);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(243, 22);
            this.textBox_author.TabIndex = 3;
            // 
            // label_genre
            // 
            this.label_genre.Location = new System.Drawing.Point(25, 99);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(184, 23);
            this.label_genre.TabIndex = 4;
            this.label_genre.Text = "Раздел литературы:";
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Items.AddRange(new object[] { "Детская литература", "Российская классика", "Зарубежная классика", "Зарубежный детектив", "Фантастика" });
            this.comboBox_genre.Location = new System.Drawing.Point(22, 125);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(250, 24);
            this.comboBox_genre.TabIndex = 5;
            // 
            // label_ageLimit
            // 
            this.label_ageLimit.Location = new System.Drawing.Point(348, 99);
            this.label_ageLimit.Name = "label_ageLimit";
            this.label_ageLimit.Size = new System.Drawing.Size(207, 23);
            this.label_ageLimit.TabIndex = 6;
            this.label_ageLimit.Text = "Возрастное ограничение:";
            // 
            // comboBox_ageLimit
            // 
            this.comboBox_ageLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ageLimit.FormattingEnabled = true;
            this.comboBox_ageLimit.Items.AddRange(new object[] { "0+", "6+", "12+", "16+", "18+" });
            this.comboBox_ageLimit.Location = new System.Drawing.Point(348, 125);
            this.comboBox_ageLimit.Name = "comboBox_ageLimit";
            this.comboBox_ageLimit.Size = new System.Drawing.Size(243, 24);
            this.comboBox_ageLimit.TabIndex = 7;
            // 
            // label_price
            // 
            this.label_price.Location = new System.Drawing.Point(35, 190);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(81, 23);
            this.label_price.TabIndex = 8;
            this.label_price.Text = "Цена:";
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.Location = new System.Drawing.Point(152, 188);
            this.numericUpDown_price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_price.TabIndex = 9;
            this.numericUpDown_price.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label_pages
            // 
            this.label_pages.Location = new System.Drawing.Point(35, 230);
            this.label_pages.Name = "label_pages";
            this.label_pages.Size = new System.Drawing.Size(96, 45);
            this.label_pages.TabIndex = 10;
            this.label_pages.Text = "Количество страниц:";
            // 
            // numericUpDown_pages
            // 
            this.numericUpDown_pages.Location = new System.Drawing.Point(152, 240);
            this.numericUpDown_pages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_pages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDown_pages.Name = "numericUpDown_pages";
            this.numericUpDown_pages.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_pages.TabIndex = 11;
            this.numericUpDown_pages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_yearOfPubl
            // 
            this.label_yearOfPubl.Location = new System.Drawing.Point(35, 296);
            this.label_yearOfPubl.Name = "label_yearOfPubl";
            this.label_yearOfPubl.Size = new System.Drawing.Size(100, 23);
            this.label_yearOfPubl.TabIndex = 12;
            this.label_yearOfPubl.Text = "Год издания:";
            // 
            // numericUpDown_yaerOfPubl
            // 
            this.numericUpDown_yaerOfPubl.Location = new System.Drawing.Point(151, 297);
            this.numericUpDown_yaerOfPubl.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            this.numericUpDown_yaerOfPubl.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            this.numericUpDown_yaerOfPubl.Name = "numericUpDown_yaerOfPubl";
            this.numericUpDown_yaerOfPubl.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_yaerOfPubl.TabIndex = 13;
            this.numericUpDown_yaerOfPubl.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label_publisher
            // 
            this.label_publisher.Location = new System.Drawing.Point(348, 187);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(100, 23);
            this.label_publisher.TabIndex = 14;
            this.label_publisher.Text = "Издатель:";
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(348, 213);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(243, 22);
            this.textBox_publisher.TabIndex = 15;
            // 
            // label_count
            // 
            this.label_count.Location = new System.Drawing.Point(35, 339);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(100, 41);
            this.label_count.TabIndex = 16;
            this.label_count.Text = "Количесво экземпляров:";
            // 
            // numericUpDown_count
            // 
            this.numericUpDown_count.Location = new System.Drawing.Point(151, 349);
            this.numericUpDown_count.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numericUpDown_count.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDown_count.Name = "numericUpDown_count";
            this.numericUpDown_count.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_count.TabIndex = 17;
            this.numericUpDown_count.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(35, 402);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(143, 23);
            this.button_create.TabIndex = 18;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label_error
            // 
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(215, 402);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(306, 23);
            this.label_error.TabIndex = 19;
            // 
            // label_ageLimErr
            // 
            this.label_ageLimErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ageLimErr.ForeColor = System.Drawing.Color.Red;
            this.label_ageLimErr.Location = new System.Drawing.Point(597, 125);
            this.label_ageLimErr.Name = "label_ageLimErr";
            this.label_ageLimErr.Size = new System.Drawing.Size(33, 23);
            this.label_ageLimErr.TabIndex = 20;
            // 
            // label_titleErr
            // 
            this.label_titleErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_titleErr.ForeColor = System.Drawing.Color.Red;
            this.label_titleErr.Location = new System.Drawing.Point(278, 42);
            this.label_titleErr.Name = "label_titleErr";
            this.label_titleErr.Size = new System.Drawing.Size(33, 23);
            this.label_titleErr.TabIndex = 21;
            // 
            // label_genreErr
            // 
            this.label_genreErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_genreErr.ForeColor = System.Drawing.Color.Red;
            this.label_genreErr.Location = new System.Drawing.Point(278, 126);
            this.label_genreErr.Name = "label_genreErr";
            this.label_genreErr.Size = new System.Drawing.Size(33, 23);
            this.label_genreErr.TabIndex = 22;
            // 
            // label_authErr
            // 
            this.label_authErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_authErr.ForeColor = System.Drawing.Color.Red;
            this.label_authErr.Location = new System.Drawing.Point(597, 42);
            this.label_authErr.Name = "label_authErr";
            this.label_authErr.Size = new System.Drawing.Size(33, 23);
            this.label_authErr.TabIndex = 23;
            // 
            // label_PublErr
            // 
            this.label_PublErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PublErr.ForeColor = System.Drawing.Color.Red;
            this.label_PublErr.Location = new System.Drawing.Point(597, 209);
            this.label_PublErr.Name = "label_PublErr";
            this.label_PublErr.Size = new System.Drawing.Size(33, 23);
            this.label_PublErr.TabIndex = 24;
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.label_PublErr);
            this.Controls.Add(this.label_authErr);
            this.Controls.Add(this.label_genreErr);
            this.Controls.Add(this.label_titleErr);
            this.Controls.Add(this.label_ageLimErr);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.numericUpDown_count);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.textBox_publisher);
            this.Controls.Add(this.label_publisher);
            this.Controls.Add(this.numericUpDown_yaerOfPubl);
            this.Controls.Add(this.label_yearOfPubl);
            this.Controls.Add(this.numericUpDown_pages);
            this.Controls.Add(this.label_pages);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.comboBox_ageLimit);
            this.Controls.Add(this.label_ageLimit);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_title);
            this.Name = "NewBook";
            this.Text = "NewBook";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yaerOfPubl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label_titleErr;
        private System.Windows.Forms.Label label_genreErr;
        private System.Windows.Forms.Label label_authErr;
        private System.Windows.Forms.Label label_PublErr;

        private System.Windows.Forms.Label label_ageLimErr;

        private System.Windows.Forms.Label label_error;

        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
        private System.Windows.Forms.Label label_pages;
        private System.Windows.Forms.NumericUpDown numericUpDown_pages;
        private System.Windows.Forms.Label label_yearOfPubl;
        private System.Windows.Forms.NumericUpDown numericUpDown_yaerOfPubl;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.NumericUpDown numericUpDown_count;
        private System.Windows.Forms.Button button_create;

        private System.Windows.Forms.ComboBox comboBox_ageLimit;

        private System.Windows.Forms.Label label_ageLimit;

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.ComboBox comboBox_genre;

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_author;

        #endregion
    }
}
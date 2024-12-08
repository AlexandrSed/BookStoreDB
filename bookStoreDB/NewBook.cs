using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace bookStoreDB
{
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            
            if (!CheckFields())
                return;
                
            var title = this.textBox_title.Text;
            var author = this.textBox_author.Text;
            var genre = this.comboBox_genre.SelectedItem.ToString();
            var price = this.numericUpDown_price.Value;
            var pages = this.numericUpDown_pages.Value;
            var publisher = textBox_publisher.Text;
            var yearOfPublication = numericUpDown_yaerOfPubl.Value;
            var ageLimit = this.comboBox_ageLimit.SelectedItem.ToString();
            var count = numericUpDown_count.Value;

            BsonDocument createdBook = new BsonDocument
            {
                {"title", title},
                {"author", author},
                {"genre", genre},
                {"price", price},
                {"pages", pages},
                {"publisher", publisher},
                {"yearOfPublication", yearOfPublication},
                {"ageLimit", ageLimit},
                {"count", count}
            };

            using (MongoClient db = new MongoClient())
            {
                var books = db.GetDatabase("bookstore")
                    .GetCollection<BsonDocument>("books");
                
                books.InsertOne(createdBook);
                Close();
            }
        }

        private bool CheckFields()
        {
            bool result = true;
            
            if (this.comboBox_genre.SelectedItem == null)
            {
                this.label_genreErr.Text = "*";
                result = false;
            }

            if (this.comboBox_ageLimit.SelectedItem == null)
            {
                this.label_ageLimErr.Text = "*";
                result = false;
            }

            if (this.textBox_title.Text == String.Empty)
            {
                this.label_titleErr.Text = "*";
                result = false;
            }

            if (this.textBox_author.Text == String.Empty)
            {
                this.label_authErr.Text = "*";
                result = false;
            }

            if (this.textBox_publisher.Text == String.Empty)
            {
                this.label_PublErr.Text = "*";
                result = false;
            }

            if (!result)
                this.label_error.Text = "Заполните пустые поля";

            return result;
        }
    }
}
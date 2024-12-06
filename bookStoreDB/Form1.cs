using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace bookStoreDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MongoClient _client;

        private void Form1_Load(object sender, EventArgs e)
        {
            _client = new MongoClient(Properties.Settings.Default.ConnString);

            OutputBooksData(new BsonDocument());
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            var title = this.textBox_title.Text;
            var author = this.textBox_author.Text;
            var minPrice = this.numericUpDown_minPrice.Value;
            var maxPrice = this.numericUpDown_maxPrice.Value;
            var minPages = this.numericUpDown_minPages.Value;
            var maxPages = this.numericUpDown_maxPages.Value;

            var filter = new BsonDocument("$and", new BsonArray{
                new BsonDocument("title", new BsonDocument("$regex", ".*"+title+".*")),
                new BsonDocument("author", new BsonDocument("$regex", ".*"+author+".*")),
                new BsonDocument("price", new BsonDocument("$gte", minPrice)),
                new BsonDocument("price", new BsonDocument("$lte", maxPrice)),
                new BsonDocument("pages", new BsonDocument("$gte", minPages)),
                new BsonDocument("pages", new BsonDocument("$lte", maxPrice))

            });

        OutputBooksData(filter);
        }

        private void OutputBooksData(FilterDefinition<BsonDocument> filter)
        {
            var db = _client.GetDatabase("bookstore");
 
            IMongoCollection<BsonDocument> booksCollection = db.GetCollection<BsonDocument>("books");
            
            List<BsonDocument> books = booksCollection.Find(filter).ToList();

            DataTable dataTable = new DataTable();

            foreach (var book in books)
            {
                if (dataTable.Columns.Count == 0)
                {
                    foreach (var colName in book.Names)
                    {
                        if(colName != "_id")
                            dataTable.Columns.Add(colName);
                    }
                }

                dataTable.Rows.Add(new object[]
                {
                    book["title"], 
                    book["author"],
                    book["genre"],
                    book["price"],
                    book["pages"],
                    book["publisher"],
                    book["yearOfPublication"],
                    book["ageLimit"],
                    book["count"]
                });
            }

            // Display the data from the data table in the data grid view.
            this.booksInfoView.DataSource = dataTable;
        }
    }
}
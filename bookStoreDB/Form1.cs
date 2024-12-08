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

            OutputBooksData(new BsonDocument(), new BsonDocument());
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            var title = this.textBox_title.Text;
            var author = this.textBox_author.Text;
            var minPrice = this.numericUpDown_minPrice.Value;
            var maxPrice = this.numericUpDown_maxPrice.Value;
            var minPages = this.numericUpDown_minPages.Value;
            var maxPages = this.numericUpDown_maxPages.Value;
            var sortField = DefineSortField(this.comboBox_sort.SelectedIndex);
            BsonDocument sort;

            if (sortField == "")
                sort = new BsonDocument();
            else if (this.radioButton_ascend.Checked)
                sort = new BsonDocument(sortField, 1);
            else if (this.radioButton_descend.Checked)
                sort = new BsonDocument(sortField, -1);
            else
                sort = new BsonDocument();
            
            var filter = new BsonDocument("$and", new BsonArray{
                new BsonDocument("title", new BsonDocument("$regex", ".*"+title+".*")),
                new BsonDocument("author", new BsonDocument("$regex", ".*"+author+".*")),
                new BsonDocument("price", new BsonDocument("$gte", minPrice)),
                new BsonDocument("price", new BsonDocument("$lte", maxPrice)),
                new BsonDocument("pages", new BsonDocument("$gte", minPages)),
                new BsonDocument("pages", new BsonDocument("$lte", maxPages))

            });

        OutputBooksData(filter, sort);
        }

        private void OutputBooksData(FilterDefinition<BsonDocument> filter, SortDefinition<BsonDocument> sort)
        {
            var db = _client.GetDatabase("bookstore");
 
            var booksCollection = db.GetCollection<BsonDocument>("books");
            
            List<BsonDocument> books = booksCollection.Find(filter).Sort(sort).ToList();

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

        private string DefineSortField(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return "price";
                case 1:
                    return "pages";
                case 2:
                    return "yearOfPublication";
                case 3:
                    return "count";
            }

            return "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var book = new NewBook();
            book.FormClosed += new FormClosedEventHandler(book_FormClosed);
            book.ShowDialog();
        }
        
        private void book_FormClosed(object sender, FormClosedEventArgs e)
        {
            OutputBooksData(new BsonDocument(), new BsonDocument());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var db = _client.GetDatabase("bookstore");

            var books = db.GetCollection<BsonDocument>("books");

            var booksForDeleting = this.booksInfoView.SelectedRows;

            if (booksForDeleting.Count == 0)
                return;
            
            foreach (DataGridViewRow book in booksForDeleting)
            {
                books.DeleteOne(ConvertDataGridRowToBson(book));
            }
            
            OutputBooksData(new BsonDocument(), new BsonDocument());
        }

        private BsonDocument ConvertDataGridRowToBson(DataGridViewRow row)
        {
            return new BsonDocument
            {
                {"title", row.Cells[0].Value.ToString()},
                {"author", row.Cells[1].Value.ToString()},
                {"genre", row.Cells[2].Value.ToString()},
                {"price", int.Parse(row.Cells[3].Value.ToString())},
                {"pages", int.Parse(row.Cells[4].Value.ToString())},
                {"publisher", row.Cells[5].Value.ToString()},
                {"yearOfPublication", int.Parse(row.Cells[6].Value.ToString())},
                {"ageLimit", row.Cells[7].Value.ToString()},
                {"count", int.Parse(row.Cells[8].Value.ToString())}
            };
        }
    }
}
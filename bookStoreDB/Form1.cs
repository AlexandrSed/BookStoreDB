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

        private void Form1_Load(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient(Properties.Settings.Default.ConnString);
            
            var db = client.GetDatabase("bookstore");
 
            IMongoCollection<BsonDocument> booksCollection = db.GetCollection<BsonDocument>("books");
            
            List<BsonDocument> books = booksCollection.Find(new BsonDocument()).ToList();

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
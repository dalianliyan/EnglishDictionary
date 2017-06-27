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

namespace EnglishDict
{
    public partial class Form1 : Form
    {
        private string mConnectString = "mongodb://sys:oracle@ds139942.mlab.com:39942";
        private IMongoClient mClient;
        private IMongoDatabase mDatabase;
    

        public Form1()
        {
            InitializeComponent();

            try
            {
                mClient = new MongoClient(mConnectString);
                mDatabase = mClient.GetDatabase("english_dictionary");
                IMongoCollection<BsonDocument> collection = mDatabase.GetCollection<BsonDocument>("Main");
                var document = new BsonDocument
                {
                    { "address" , new BsonDocument
                        {
                            { "street", "2 Avenue" },
                            { "zipcode", "10075" },
                            { "building", "1480" },
                            { "coord", new BsonArray { 73.9557413, 40.7720266 } }
                        }
                    },
                    { "borough", "Manhattan" },
                    { "cuisine", "Italian" },
                    { "grades", new BsonArray
                        {
                            new BsonDocument
                            {
                                { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                                { "grade", "A" },
                                { "score", 11 }
                            },
                            new BsonDocument
                            {
                                { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                                { "grade", "B" },
                                { "score", 17 }
                            }
                        }
                    },
                    { "name", "Vella" },
                    { "restaurant_id", "41704620" }
                };
                collection.InsertOneAsync(document);
            }
            catch (Exception)
            {                
                throw;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

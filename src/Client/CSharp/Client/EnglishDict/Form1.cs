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

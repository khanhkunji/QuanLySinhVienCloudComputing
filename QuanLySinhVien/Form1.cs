using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmQLSV : Form
    {
        private IMongoCollection<sinhvien> sinhVienCollection;

        public frmQLSV()
        {
            InitializeComponent();
            ConnectToMongoDB();
        }

        private void ConnectToMongoDB()
        {
            string connectionString = "mongodb+srv://admin:280602@qlsv.stbdprb.mongodb.net/?retryWrites=true&w=majority&appName=qlsv";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("qlsvDB");  //lay ten database
            sinhVienCollection = database.GetCollection<sinhvien>("qlsv");  //lay ten collection
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var students = sinhVienCollection.Find(_ => true).ToList();
            gridviewDSSV.DataSource = students;
        }

    }
}

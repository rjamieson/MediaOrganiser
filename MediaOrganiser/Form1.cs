using DAL;
using DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaOrganiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
          //  UnitOfWork context = new UnitOfWork();
           // var drives = context.DriveRepository.GetAll();
          //  context.DriveRepository.Add(new Drive() { Name = "Test", CurrentSize = 120 }, new Drive() { Name = "Test2" });
          //  context.Save();
         //   var y = context.DriveRepository.GetSingle(x => x.Name == "Test");
        //    y.MaxSize = 300;
         //   context.DriveRepository.Update(y);
          //  context.Save();
            var folderPath = folderBrowserDialog1.ShowDialog();
        }

        private void GetFolderItems(string path)
        {
            var subItems = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            Drive drive = new Drive { Name = path };
            var x = "random variable";
            foreach(var item in subItems)
            {
                if (File.Exists(item))
                {
                    Item dbItem = new Item();
                }
                else
                {
                    Folder folder = new Folder {  };
                }
                var x = item;
            }
          //  FileInfo folder = File.
        }
    }
}

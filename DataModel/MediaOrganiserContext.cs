using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class MediaOrganiserContext : DbContext
    {
        public MediaOrganiserContext() : base("name=MediaDbConnectionString")
        {

        }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}

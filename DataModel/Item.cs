using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Item
    {
        public int ItemId { get; set; }

        public int FolderId { get; set; }

        public string Name { get; set; }

        public decimal Size { get; set; }

        public string Extension { get; set; }

        [ForeignKey("FolderId")]
        public Folder Folder { get; set; }
    }
}

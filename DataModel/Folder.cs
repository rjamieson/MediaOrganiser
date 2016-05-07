using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Folder
    {
        public int FolderId { get; set; }
        
        public int DriveId { get; set; }

        public int ParentFolderId { get; set; }

        public string Name { get; set; }

        public decimal Size { get; set; }

        [ForeignKey("DriveId")]
        public Drive Drive { get; set; }

        [ForeignKey("ParentFolderId")]
        public Folder ParentFolder { get; set; }
    }
}

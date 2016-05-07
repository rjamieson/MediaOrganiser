using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Drive
    {
        public int DriveId { get; set; }

        public string Name { get; set; }

        public decimal MaxSize { get; set; }

        public decimal CurrentSize { get; set; }
    }
}

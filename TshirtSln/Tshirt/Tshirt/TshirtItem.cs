using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tshirt
{
   public class TshirtItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Date { get; set; }
        public string Color { get; set; }
        public string Adrress { get; set; }
        public string Size { get; set; }
        public bool Done { get; set; }
    }
}

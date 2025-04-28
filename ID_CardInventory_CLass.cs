using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ID_Card_Inventory
{
  public class ID_CardInventory_CLass
    {
        public string Name { get; set; }
        public string Surnmae { get; set; }
        public string ID_Number { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Date_Of_Issue { get; set; }
 
        
        public ID_CardInventory_CLass(string name,string suName, string IdNum, string Depts,string position,string dateofIssue)
        {
            Name = name;
            Surnmae = suName;
            ID_Number = IdNum;
            Department = Depts;
            Position = position;
            Date_Of_Issue = dateofIssue;

        }
    }
}

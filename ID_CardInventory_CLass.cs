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
        public int Department { get; set; }
        public string Position { get; set; }
        public int employementStatus { get; set; } // Assuming this is an integer representing employment status
        public string Date_Of_Issue { get; set; }
        public int costCenter { get; set; } // Assuming this is an integer representing cost center
        public Image ID_Photo { get; set; } // Assuming you want to store the photo as an Image object


        public ID_CardInventory_CLass(string name,string suName, string IdNum, int Depts,string position,string dateofIssue, Image image,int costcenter, int employstat)
        {
            Name = name;
            Surnmae = suName;
            ID_Number = IdNum;
            Department = Depts;
            Position = position;
            Date_Of_Issue = dateofIssue;
            ID_Photo = image; // Assuming you want to store the photo as an Image object
            employementStatus = employstat; // Assuming this is an integer representing employment status
            costCenter = costcenter; // Assuming this is an integer representing cost center


        }
    }
}

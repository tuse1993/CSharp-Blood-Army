using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodArmy.Entity
{
   public class Reciever:Person{
       
       string name;
       int noOfUnits;

       public Reciever(){
           this.name = string.Empty;
           this.noOfUnits=0;
        }
       public int NoOfUnits{
           set { this.noOfUnits = value; }
           get { return this.noOfUnits; }
       }
       public string Name
       {
           set { this.name = value; }
           get { return this.name; }
       }

    }
}

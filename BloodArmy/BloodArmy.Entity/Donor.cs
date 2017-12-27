using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodArmy.Entity
{
    public class Donor:Person
    {   
        string userId;
        short  available;
        DateTime birthDate;
        int requests;

        public Donor()
        {   
            this.userId=string.Empty;
            bool available=false;
            this.requests = 0;
        }
       
        public string UserId
        {
            set { this.userId = value; }
            get { return this.userId; }
        }
       public short Available
        {
            set { this.available = value; }
            get { return this.available; }
        }

        public DateTime BirthDate
        {
            set { this.birthDate = value; }
            get { return this.birthDate; }
        }
        public int Requests
        {
            set { this.requests = value; }
            get { return this.requests; }
        }

    }
}

    
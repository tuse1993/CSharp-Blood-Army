using BloodArmy.Data;
using BloodArmy.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodArmy.Core
{
    public class PersonService
    {
        PersonDataAccess personDataAccess = new PersonDataAccess();

        public int Add(Donor donor)
        {
            return personDataAccess.Add(donor);
        }

        public int AddReciever(Reciever reciever, string donorUserId)
        {
            return personDataAccess.AddReciever(reciever, donorUserId);
        }

        public int Edit(Donor donor)
        {
            return personDataAccess.Edit(donor);
        }

        public SqlDataAdapter Login(string userID, string pass)
        {
             return personDataAccess.Login(userID,pass);
        }

        public List<Donor> GetByBloodGroup(string bloodGroup, string thana)
        {
            return personDataAccess.GetByBloodGroup(bloodGroup, thana);
        }

        public int Request(Donor donor)
        {
            return personDataAccess.Request(donor);
        }

        public Reciever AcceptRequest(string userId)
        {
            return personDataAccess.AcceptRequestRequest(userId);
        }

        public Donor LoggedPerson(string userID)
        {
            return personDataAccess.LoggedPerson(userID);
        }

        public int RejectRequest(string userID)
        {
            return personDataAccess.RejectRequest(userID);
        }

        /*
      class PersonNameComparer : IComparer<Person>
      {
          public int Compare(Person x, Person y)
          {
              return string.Compare(x.Name, y.Name);
          }
      }*/
    }
}



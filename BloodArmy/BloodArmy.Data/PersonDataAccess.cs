using BloodArmy.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodArmy.Data
{
    public class PersonDataAccess
    {
        public int Add(Donor donor)
        {
            
            string query = "INSERT into Person (FirstName,LastName,Email,Password,Phone,Gender,Division,District,Thana,StreetAddress,BloodGroup,UserID,Available,BirthDate) " +
                   " VALUES ('" + donor.FirstName + "', '" + donor.LastName + "','" + donor.Email + "', '" + donor.Password + "','" + donor.PhoneNumber + "','" + donor.Gender + "','" + donor.Division + "','" + donor.District + "','" + donor.Thana + "','" + donor.StreetAddress + "','" + donor.BloodGroup + "','" + donor.UserId + "','" + donor.Available + "','" + donor.BirthDate + "');";
            return DataAccess.ExecuteQuery(query);
        }

        public int AddReciever(Reciever reciever,string donorUserId)
        {
            string query = "INSERT into Reciever (UserID,RecieverName,RecieverNumber,RecieverThana,RecieverDistrict,RecieverBloodGroup) " +
                   " VALUES ('" + donorUserId + "', '" + reciever.Name + "','" + reciever.PhoneNumber + "', '" + reciever.Thana + "','" + reciever.District + "','" + reciever.BloodGroup + "');";
            return DataAccess.ExecuteQuery(query);
        }

        public int Request(Donor donor)
        {
            string query = "UPDATE Person SET Requests='" + donor.Requests + "' WHERE UserID='" + donor.UserId + "'";
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Donor donor)
        {
            string query = "UPDATE Person SET FirstName='" + donor.FirstName + "', LastName='" + donor.LastName + "', Email='" + donor.Email + "', Password='" + donor.Password + "', Phone='" + donor.PhoneNumber + "', Gender='" + donor.Gender + "', Division='" + donor.Division + "', District='" + donor.District + "', Thana='" + donor.Thana + "', StreetAddress='" + donor.StreetAddress + "', BloodGroup='" + donor.BloodGroup + "', Available='" + donor.Available + "' WHERE UserID='" + donor.UserId + "'";
           
            return DataAccess.ExecuteQuery(query);
        }

        public SqlDataAdapter Login(string userId, string pass)
        {

            string query = "SELECT * FROM Person WHERE UserID='" + userId + "' AND Password='" + pass + "' ";
            SqlDataAdapter adapt = DataAccess.GetLoginData(query);
            
            return adapt;
           
        }

        public Reciever AcceptRequestRequest(string userId)
        {

            string query = "SELECT * FROM Reciever WHERE UserID='" + userId + "'";
          
            SqlDataReader reader = DataAccess.GetData(query);
            Reciever reciever = new Reciever();
            while (reader.Read())
            {               
                if (reader.HasRows)
                {
                    reciever = new Reciever();
                    reciever.Name = reader["RecieverName"].ToString();
                    reciever.PhoneNumber = reader["RecieverNumber"].ToString();
                    reciever.Thana = reader["RecieverThana"].ToString();
                    reciever.District = reader["RecieverDistrict"].ToString();
                    reciever.BloodGroup = reader["RecieverBloodGroup"].ToString();

                }
            }
            return reciever;            
        }

        public List<Donor> GetByBloodGroup(string bloodGroup, string thana)
        {
            short available = 1;
            string query = "SELECT FirstName, Thana, UserID FROM Person WHERE BloodGroup='" + bloodGroup + "' AND Thana='" + thana +"' AND Available='" + available  +"'";
            SqlDataReader reader = DataAccess.GetData(query);

            List<Donor> donorList = new List<Donor>();
        
            while(reader.Read()){
                Donor donor = null;
                if (reader.HasRows)
                {
                    donor = new Donor();
                    donor.FirstName = reader["FirstName"].ToString();
                    donor.Thana = reader["Thana"].ToString();
                    donor.UserId = reader["UserID"].ToString();
                    donorList.Add(donor);
                }               
            }
            return donorList;
            
        }
        public Donor LoggedPerson(string userID)
        { 
            string query = "SELECT FirstName, LastName, Email, Password, Phone, Gender,Division,District, Thana, StreetAddress, BloodGroup, UserID, Available, BirthDate,Requests FROM Person WHERE UserID='" + userID +"' ";
            SqlDataReader reader = DataAccess.GetData(query);
            Donor donor = new Donor();
                         
            while(reader.Read()){             
                if (reader.HasRows){
                    donor.FirstName = reader["FirstName"].ToString();
                    donor.LastName = reader["LastName"].ToString();
                    donor.Email = reader["Email"].ToString();
                    donor.Password = reader["Password"].ToString();
                    donor.PhoneNumber = reader["Phone"].ToString();
                    donor.StreetAddress = reader["StreetAddress"].ToString();
                    donor.Thana = reader["Thana"].ToString();
                    donor.UserId = reader["UserID"].ToString();
                    donor.Requests = Convert.ToInt32(reader["Requests"]);
                }               
            }
            return donor;
        }


        public int RejectRequest(string userID)
        {
            string query = "DELETE FROM Reciever WHERE UserID='" + userID+"'";
            return DataAccess.ExecuteQuery(query);
        }
    }

}

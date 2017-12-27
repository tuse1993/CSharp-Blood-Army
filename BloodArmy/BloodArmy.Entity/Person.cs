using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodArmy.Entity
{
    public class Person{
        
        string firstName;
        string lastName;
        string email;
        string password;        
        string phoneNumber;
        string gender;
        string division;
        string district;
        string thana;
        string streetAddress;
        string bloodGroup;

        public Person(){
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
            this.password = string.Empty;          
            this.phoneNumber = string.Empty;
            this.gender = "";
            this.division = string.Empty; 
            this.district = string.Empty;
            this.thana = string.Empty;
            this.streetAddress = string.Empty;
            this.bloodGroup = string.Empty;
        }

        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }

        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }

        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

        public string PhoneNumber
        {
            set { this.phoneNumber = value; }
            get { return this.phoneNumber; }
        }

        public string Gender {
            set { this.gender = value; }
            get { return this.gender; }
        }


        public string Division
        {
            set { this.division = value; }
            get { return this.division; }
        }

        public string District
        {
            set { this.district = value; }
            get { return this.district; }
        }


        public string Thana
        {
            set { this.thana = value; }
            get { return this.thana; }
        }

        public string StreetAddress
        {
            set { this.streetAddress = value; }
            get { return this.streetAddress; }
        }

        public string BloodGroup
        {
            set { this.bloodGroup = value; }
            get { return this.bloodGroup; }
        }
    }
}

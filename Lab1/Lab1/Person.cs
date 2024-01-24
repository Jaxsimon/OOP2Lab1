using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {

        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favouriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }


        public Person(int personID = 0, string firstName = "N/A", string lastName = "N/A", string favouriteColour = "N/A", int age = 0, bool isWorking = false)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            return $"{this.personID}: {this.firstName} {this.lastName}'s favourite colour is {this.favouriteColour} \n";
        }

        public string ChangeFavouriteColour()
        {
            this.favouriteColour = "White";
            return $"{this.firstName} {this.lastName}'s favourite colour is: {this.favouriteColour} \n";
        }
        public string GetAgeInTenYears()
        {
            int age = this.age + 10;
            return $"{this.firstName} {this.lastName}'s Age in 10 years is: {age} \n";
        }

        public override string ToString()
        {
            return $"Person ID: {this.personID} \n" +
                $"First Name: {this.firstName} \n" +
                $"Last Name: {this.lastName} \n" +
                $"Favourite Colour: {this.favouriteColour} \n" +
                $"Age: {this.age} \n" +
                $"Is Working: {this.isWorking} \n";
        }
    }

}
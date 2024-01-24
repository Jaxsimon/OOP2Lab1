using System.Diagnostics.CodeAnalysis;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Creating People
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(person2.DisplayPersonInfo());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person1.ChangeFavouriteColour());
            Console.WriteLine(person4.GetAgeInTenYears());


            //Relationships
            Relation relationship1 = new Relation(person2, person4, Relation.RelationType.Sister);
            Relation relationship2 = new Relation(person1, person3, Relation.RelationType.Brother);

            Console.WriteLine(relationship1.ShowRelationship(person2, person4, Relation.RelationType.Sister));
            Console.WriteLine(relationship2.ShowRelationship(person1, person3, Relation.RelationType.Brother));


            //Person List
            List<Person> personList = new List<Person>();
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);

            //Calculate Average
            double sum = 0;
            foreach (Person person in personList)
            {
                sum += person.age;
            }
            double average = sum / personList.Count;
            Console.WriteLine($"Average age is: {average} \n");

            //Print Youngest and Oldest
            int youngest = personList.Min(person => person.age);
            int oldest = personList.Max(person => person.age);
            foreach (Person person in personList)
            {
                if (person.age == youngest)
                {
                    Console.WriteLine($"The youngest person is: {person.firstName} \n");
                }

                if (person.age == oldest)
                {
                    Console.WriteLine($"The oldest person is: {person.firstName} \n");
                }
            }

            foreach (Person person in personList)
            {
                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());
                }
            }

            foreach (Person person in personList)
            {
                if (person.favouriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }


        }
    }
}

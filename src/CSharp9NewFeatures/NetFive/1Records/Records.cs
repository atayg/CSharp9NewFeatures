using System;

namespace NetFive._1Records
{
    //Creating Record Types
    public record Person(string FirstName, string LastName);

    public record Person2
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public record Person3
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public record Person4
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public record Person5
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] IdentityNumber { get; set; }
    }


    public class Records
    {
        //Creating New Instance of Records
        public Person personGA = new Person("Gökhan", "Atay");

        public Person2 personGA2 = new Person2 { FirstName = "Gökhan", LastName = "Atay" };

        public Person3 personGA3 = new Person3 { FirstName = "Gökhan", LastName = "Atay" };


    }


    //Inheritance
    // !!! Record just can inherit another records or object. 

    public record Developer : Person
    {
        public string Title { get; set; }

        public Developer(string FirstName, string LastName, string Title) : base(FirstName, LastName)
        {
        }
    }

    public record Manager(string FirstName, string LastName, decimal Salary) : Person(FirstName, LastName);


}

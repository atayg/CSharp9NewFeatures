using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFive._6FitAndFinishFeatures
{
    public class CovariantReturnTypes
    {

    }

    public class Person
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public Person()
        { }
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual Person GetPerson()
        {
            return new Person();
        }
    }

    public class Employee : Person
    {
        private string Department { get; set; }
        public Employee()
        { }
        public Employee(int id, string firstName, string lastName,
        string department) : base(id, firstName, lastName)
        {
            Department = department;
        }
        public override Employee GetPerson()
        {
            return new Employee();
        }
    }
}

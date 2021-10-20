 using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1; //declares the field nextId, changing value is NOT stored within employer object
        public string Value { get; set; }

        public Employer() //Assigns the value of nextId to the id field, then increments nextId. Every new Employer gets a differnt Id number
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this() //Assigns the value field and initializes id for the object via 'constructor chaining'
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

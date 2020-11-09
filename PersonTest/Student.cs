using System;
namespace PersonTest
{
    public class Student :  Person
    {

        public Student(string name) : base(name)
        {
            
        }
        public string Study()
        {
            return$"{Name} is Studying";
        }
        public override string ToString()
        {
            return Study();
        }
    }
}
using System;
namespace PersonTest
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            
        }
        public string Explain()
        {
            return$"{Name} is explaining";
        }
        public override string ToString()
        {
            return Explain();
        }
    }
}
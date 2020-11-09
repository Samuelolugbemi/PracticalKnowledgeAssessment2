using System;

namespace PersonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("Folake");
            Student student1 = new Student("James");
            Student student2 = new Student("Stuart");


            Console.WriteLine("Persons processed individually");
            Console.WriteLine(teacher1.Explain());
            Console.WriteLine(student1.Study());
            Console.WriteLine(student2.Study());

            Console.WriteLine("\nPersons processed polymorphically");
            Person[] people = new Person[3]{teacher1, student1, student2};

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

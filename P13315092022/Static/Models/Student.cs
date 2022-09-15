using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Models
{
    class Student
    {
        //Field
        public string Name; 
        public string SurName { get; set; }
        //Static Field
        public int Age;
        static int S_Id;
        public readonly int Id;

        static Student()
        {
            S_Id = 0;
            Console.WriteLine($"Ilk Telebe Yarandi");
        }

        public Student()
        {
            S_Id++;
            Id = S_Id;
            Console.WriteLine($"Telebe Yarandi Id: {Id} - {S_Id}");
        }

        public static double Grade { get; set; }

        public static void ShowInfo(string fuelForOneKm)
        {
            Console.WriteLine(S_Id);
        }

        public void Test()
        {
            Console.WriteLine(S_Id+Id);
        }
    }
}

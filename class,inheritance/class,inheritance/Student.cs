using System;
using System.Collections.Generic;
using System.Text;

namespace class_inheritance
{
    class Student
    {
        public string name;
        public string surname;
        public string address;
        public int age;

        
        public string FullName()
        {
            return $"{name} {surname}";
        }

        public string FullData()
        {
            return $"Ad Soyad:{FullName()} Yas: {age}";
        }
    }
}

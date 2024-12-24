using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectsTask.Model
{
    internal class Employee
    {
        private string surname { get; set; }
        private int age { get; set; }

        public Employee()
        {
                
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        private string ReturnAge()
        {
            return age.ToString();
        }

        public void UpdateSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string ReturnEmplyeeInfo()
        {
            return (surname, age).ToString();
        }
    }
}

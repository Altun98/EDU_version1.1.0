using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_version1._1._0
{
    public class Student
    {
        private int age;
        private string address;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 7 && value < 18)
                {
                    age = value;
                }
                else
                {
                    age = 7;
                    Console.WriteLine("sagirdin minimum yasi 7 ola biler");
                };
            }
        }
        public string Address
        {
            get { return this.address; }
            set
            {
                if (value.Length > 10)
                {
                    address = value;
                }
                else
                {
                    Console.WriteLine("Addresin uzunluqu 10 sinvoldan cox olmalidir");
                };
            }
        }
        public Student()
        {
            // bos yaradilsa bele avtomatik id verilecek
            ID = Avto.Get_ID();
        }
        public Student(string name, string surname, string patronymic, int age, string adsress)
        {
            ID = Avto.Get_ID();
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Age = age;
            this.Address = adsress;
        }

        public void Print()
        {
            Console.WriteLine($"{ID}),{Name},{Surname},{Patronymic},{age},{Address}");
        }
    }
}

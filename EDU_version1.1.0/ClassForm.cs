using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_version1._1._0
{
    public class ClassForm
    {
        public string ClassName { get; set; }
        public Student[] Students { get; set; }

        public ClassForm()
        {

        }
        public ClassForm(string name, Student[] students)
        {
            this.ClassName = name;
            this.Students = students;
        }
        public void Print()
        {
            Console.WriteLine(ClassName);
            foreach (var item in Students)
            {
                item.Print();
            }
            Console.WriteLine("--------------------------------------------------------");
        }
        public void DataCreate()
        {
            string FolderName = AppDomain.CurrentDomain.BaseDirectory + ClassName;
            string FileName = FolderName + "\\" + ClassName + ".txt";           
            Avto.AddFolder(ClassName);            
            if (!FileExixts(FileName))
            {
                FileCreate(@FileName);
            } 
            Console.WriteLine(FileName+"adinda fayil yaradildi");         
                       
            foreach (var item in Students)
            {
             Console.WriteLine($"{item.ID}),{item.Name},{item.Surname},{item.Patronymic},{item.Age},{item.Address}");

            }
            Console.WriteLine(FileName);
        }
        public void FileCreate(string path)
        {
            FileStream Fs = File.Create(path);
            Fs.Close();
        }
        public bool FileExixts(string path)
        {
            // hemin  faylin olub olmamasini oyreneir
            return File.Exists(path);
        }
        public void FileDelete(string path)
        {
            //faylin silinmesi
            File.Delete(path);
        }


    }
}

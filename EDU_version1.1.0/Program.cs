using System.Security.Cryptography.X509Certificates;

namespace EDU_version1._1._0
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Menimsetmeler


            //// sagir ve sinif claslarini fayl  ve txt terkibinde qeyd etmek
            ////sagird klasini id,ad,soyad,ata adi,yasi,adressi
            ////sinif clasinda sinif adi,sagird arrayi olmalidir 
            Student s1 = new Student(Avto.AvtoName(), Avto.AvtoSurName(), Avto.AvtoPatronymic(), Avto.AvtoAge(), Avto.AvtoAddress());
            Student s2 = new Student(Avto.AvtoName(), Avto.AvtoSurName(), Avto.AvtoPatronymic(), Avto.AvtoAge(), Avto.AvtoAddress());
            Student s3 = new Student(Avto.AvtoName(), Avto.AvtoSurName(), Avto.AvtoPatronymic(), Avto.AvtoAge(), Avto.AvtoAddress());
            Student s4 = new Student(Avto.AvtoName(), Avto.AvtoSurName(), Avto.AvtoPatronymic(), Avto.AvtoAge(), Avto.AvtoAddress());
            Student s5 = new Student(Avto.AvtoName(), Avto.AvtoSurName(), Avto.AvtoPatronymic(), Avto.AvtoAge(), Avto.AvtoAddress());
            Student s6 = new Student(Avto.AvtoName(), Avto.AvtoSurName(), Avto.AvtoPatronymic(), Avto.AvtoAge(), Avto.AvtoAddress());
            Console.WriteLine("--------------------------------------------------------");

            Student[] sa1 = { s1, s2 };
            Student[] sa2 = { s3, s4 };
            Student[] sa3 = { s5, s6 };
            //ClassForm c1 = new ClassForm("10-cu sinif", sa1);
            //ClassForm c2 = new ClassForm("11-ci sinif", sa2);
            //ClassForm c3 = new ClassForm("9-cu sinif", sa3);
            //c1.Print();
            //c2.Print();
            //c3.Print();
            //Console.WriteLine("***********************************************************");
            //DirectoryInfo d = new DirectoryInfo(@"D:");

            //string x = Environment.CurrentDirectory;
            //Console.WriteLine(x);
            #endregion
            //string s=  AppDomain.CurrentDomain.BaseDirectory; 
            //  Console.WriteLine(s); 
            //sagirdlerin hamsini oxumaq
            //adi verilmis sinifi oxumaq
            //sinif daxil ed
            ClassForm cs1 = new ClassForm("2-cu sinif",sa1);
            cs1.DataCreate();


            //goStart: 
            //    Console.WriteLine("*****Menu*****\n1)sagird ve sinifleri siyahila\n2)adi daxil edilecek sinifi oxu\n" +
            //        "3)sinifi sisteme daxil et\n" +
            //        "4)Cixis");
            //    Console.Write("Secim edin:");
            //    switch (Convert.ToInt32(Console.ReadLine()))
            //    {
            //        case 1:
            //            Console.WriteLine("1-i secdiniz");
            //            break;
            //        case 2:
            //            Console.WriteLine("2-ni secdiniz");
            //            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            //            break;
            //        case 3:
            //            Console.WriteLine("yeni daxil etmek istediyniz sinifin adini daxil edin");
            //            Console.Write("Sinifin adini yazin:");
            //            string classNameFolder = Console.ReadLine().ToString();
            //            Avto.AddFolder(classNameFolder);
            //            break;
            //        case 4:
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("ferqli secim edildi");
            //            break;
            //    }
            //    goto goStart;

            Console.ReadKey();
        }
        

    }
}

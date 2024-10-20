using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EDU_version1._1._0
{
    public static class Avto
    {
        public static int Count = 0;
        public static int Get_ID()
        {
            return ++Count;
        }

        //avtomatik olaraq yasin yazilmasi
        public static int AvtoAge()
        {
            Random rd = new Random();
            return rd.Next(7, 18);
        }
        //avtomatik olaraq adin yazilmasi
        public static string AvtoName()
        {
            List<string> listName = new List<string>();
            listName.Add("Cahid");
            listName.Add("Altun");
            listName.Add("Miri");
            listName.Add("Etibar");
            listName.Add("Qismet");
            listName.Add("Nihad");
            listName.Add("Cabbar");
            listName.Add("Hesen");
            listName.Add("Abid");
            listName.Add("Fuad");
            listName.Add("Nahid");
            listName.Add("Qasim");
            listName.Add("Qalib");
            listName.Add("Hemid");
            listName.Add("Resad");
            listName.Add("Ozal");
            listName.Add("Etimad");
            listName.Add("Samir");
            listName.Add("Cavid");
            listName.Add("Serxan");
            listName.Add("Qabil");
            listName.Add("Aqsin");
            listName.Add("Nurlan");
            listName.Add("Fariz");
            listName.Add("Ural");
            listName.Add("Uqur");
            listName.Add("Yusif");
            listName.Add("Emin");
            listName.Add("Elvin");
            listName.Add("Vuqar");
            listName.Add("Mahir");
            listName.Add("Ilkin");
            listName.Add("Abdulla");
            listName.Add("Cesur");
            listName.Add("Qazax");
            listName.Add("Cingiz");
            listName.Add("Sahil");
            listName.Add("Ilqar");
            listName.Add("Araz");
            listName.Add("Efqan");
            listName.Add("Natiq");
            listName.Add("Namiq");
            listName.Add("Hesen");
            listName.Add("Rufet");
            listName.Add("Elcin");
            listName.Add("Rafael");
            listName.Add("Rza");
            listName.Add("Dasqin");
            listName.Add("Dadas");
            listName.Add("Fariz");
            Random rd = new Random();
            return listName[rd.Next(0, listName.Count)];
        }
        //avtomatik olaraq soyadin yazilmasi
        public static string AvtoSurName()
        {
            List<string> listSurName = new List<string>();
            listSurName.Add("Eliyev");
            listSurName.Add("Elizade");
            listSurName.Add("Abbasov");
            listSurName.Add("Abdullayev");
            listSurName.Add("Abısov");
            listSurName.Add("Abıyev");
            listSurName.Add("Allahyarov");
            listSurName.Add("Babayev");
            listSurName.Add("Bahadurov");
            listSurName.Add("Cəfərov");
            listSurName.Add("Cəfərli");
            listSurName.Add("Abbaslı");
            listSurName.Add("Qasımov");
            listSurName.Add("Qayıbov");
            listSurName.Add("Celilzade");
            listSurName.Add("Cəlilli");
            listSurName.Add("Qəhramanov");
            listSurName.Add("Etibarlı");
            listSurName.Add("Qazaxov");
            listSurName.Add("Xəlilli");
            Random rd = new Random();

            return listSurName[rd.Next(0, listSurName.Count)];

        }
        //avtomatik olaraq ata adinin yazilmasi
        public static string AvtoPatronymic()
        {

            List<string> listPatronymic = new List<string>();
            listPatronymic.Add("Mahir");
            listPatronymic.Add("Vuqar");
            listPatronymic.Add("Elsen");
            listPatronymic.Add("Emin");
            listPatronymic.Add("Eldeniz");
            listPatronymic.Add("Yasar");
            listPatronymic.Add("Ilkin");
            listPatronymic.Add("Zaur");
            listPatronymic.Add("Qasim");
            listPatronymic.Add("Koceri");
            listPatronymic.Add("Elbrus");
            listPatronymic.Add("Tofiq");
            listPatronymic.Add("Elxan");
            listPatronymic.Add("Hendem");
            listPatronymic.Add("Aslan");
            listPatronymic.Add("Ilkin");
            listPatronymic.Add("Sovqu");
            listPatronymic.Add("Sebiraqa");
            listPatronymic.Add("Ehtimad");
            Random rd = new Random();
            return listPatronymic[rd.Next(0, listPatronymic.Count)];

        }
        //avtomatik olaraq adresin yazilmasi
        public static string AvtoAddress()
        {
            List<string> listAdress = new List<string>();
            listAdress.Add("Bineqedi rayonu ");
            listAdress.Add("Nizami rayonu");
            listAdress.Add("Xetai rayonu");
            listAdress.Add("Sebail rayonu");
            listAdress.Add("Abseron rayonu Xirdalan seheri");
            listAdress.Add("Sumqayit seheri 1-ci mkr");
            listAdress.Add("Sumqayit seheri 2-ci mkr");
            listAdress.Add("Binededi rayomu 1-ci mkr");
            listAdress.Add("Binededi rayomu 2-ci mkr");
            listAdress.Add("Binededi rayomu 3-cu mkr");
            listAdress.Add("Sumqayit seheri 13-cu mkr");
            listAdress.Add("Sumqayit seheri 18-ci mkr");
            Random rd = new Random();
            return listAdress[rd.Next(0, listAdress.Count)];


        }
        //sinifin adina uyqun olaraq folderin yaradilmasi
        public static void AddFolder(string folderName)
        {
            // proqramin exce faylinin  yerlesdiyi yer 
            string s = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = s + folderName;
            if (!Directory.Exists(folderPath))
            {
                // folderin yaradilmasi
                Directory.CreateDirectory(folderPath);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz adda sinif movcuddur zehmet olmasa yeni ad daxil edin");
            }
        }
    }
}

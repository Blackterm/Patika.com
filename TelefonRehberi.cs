using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class TelefonRehberi
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Arayuz arayuZ = new Arayuz();
            arayuZ.arayuz();

            String Entry = Console.ReadLine();
            while (true)
            {
                if (Entry == "1")
                {
                    personManager.personAdd();
                    break;
                }
                else if (Entry == "2")
                {

                    personManager.personDelete();
                    break;
                }
                else if (Entry == "3")
                {
                    personManager.personUpdate();
                    break;
                }
                else if (Entry == "4")
                {
                    personManager.guideSearch();
                    break;
                }
                else if (Entry == "5")
                {
                    personManager.personSearch();
                    break;
                }
                else if (Entry == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }

    public class Person
    {
        public string Name;
        public string lastName;
        public int Phone;

        public Person(string Name, string lastName, int Phone)
        {
            this.Name = Name;
            this.lastName = lastName;
            this.Phone = Phone;
        }
    }
    public class Arayuz
    {
        public void arayuz()
        {
            Console.WriteLine(
                "(1)Yeni Numara Eklemek" +
                "\n(2)Varolan Numarayı Silmek" +
                "\n(3)Varolan Numarayı Güncellemek" +
                "\n(4)Rehberi Listelemek" +
                "\n(5)Rehberde Arama Yapmak" +
                "\n(6)Çıkmak için" +
                "\nLütfen Yapmak istediğiniz Numarayı Tuşalayınız");
        }
    }
    public class People
    {
        public List<Person> person = new List<Person>();
        public void people()
        {
            person.Add(new Person("Murat", "Eravşar", 1234567));
            person.Add(new Person("Adil", "Şahin", 12345678));
            person.Add(new Person("Okan", "Yılmaz", 123456789));
        }
    }
    public class PersonManager : People
    {
        public void personAdd()
        {
            Console.WriteLine("İsminiz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Telefon Numaranız:");
            int phone = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, lastName, phone);

            Console.WriteLine("{0} HOŞGELDİN!", person.Name.ToUpper());
            Console.ReadLine();
        }

        public void personDelete()
        {
            people();
            Console.WriteLine("Lütfen silmek istediğiniz kişinin ismini veya soyadını yazınız:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < person.Count; i++)
            {
                if (search == person[i].Name || search == person[i].lastName)
                {
                    Console.WriteLine("Kullanıcı {0} silmek istediğinize eminmisiniz y/n", person[i].Phone);
                    var answer = Console.ReadLine();
                    kayitvarmi = true;

                    if (answer == "y")
                    {
                        Console.WriteLine("Başarı ile silinmiştir");
                    }
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }
        public void personUpdate()
        {
            people();
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin ismini veya soyadını yazınız:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < person.Count; i++)
            {
                if (search == person[i].Name || search == person[i].lastName)
                {
                    Console.WriteLine("Adı:{0}" +
                    "\nSoyadı:{1}" +
                    "\nNumarası:{2}" +
                    "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }

        public void guideSearch()
        {
            people();
            for (var i = 0; i < person.Count; i++)
            {
                Console.WriteLine("Adı:{0}" +
                "\nSoyadı:{1}" +
                "\nNumarası:{2}" +
                "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
            }

            Console.ReadLine();

        }

        public void personSearch()
        {
            people();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz" +
                "\n**************************************" +
                "\nİsim ve Soyadına göre arama yapmak için (1)" +
                "\nNumaraya göre arama yapmak için (2)");
            var search = Console.ReadLine();
            if (search == "1")
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını veya soyadını yazınız");
                var answer = Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < person.Count; i++)
                {
                    if (answer == person[i].Name || answer == person[i].lastName)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else if (search == "2")
            {
                Console.WriteLine("Lütfen numarayı tuşlayınız");
                var answer = Convert.ToInt32(Console.ReadLine());
                bool kayitvarmi = false;
                for (var i = 0; i < person.Count; i++)
                {
                    if (answer == person[i].Phone)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz veye hatalı tuşlama yaptınız.");
            }
            Console.ReadLine();
        }

    }
}

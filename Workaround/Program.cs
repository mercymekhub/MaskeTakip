using Business.Concrete;
using Entites.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SelamVer();

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(new Person {  DateOfBirthYear=1985,
             FirstName="isim", LastName = "soyisim", NationalIdentity = 123 });

            Console.ReadLine();
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }
}

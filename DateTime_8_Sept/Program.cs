using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {



        static void Main(string[] args)
        {

            // Övning 1 

            void DateInOneWeek()
            {
                var sjuDagar = DateTime.Now.AddDays(7);
                Console.WriteLine(sjuDagar);
            }

            DateInOneWeek();

            // Övning 2 

            void HalloweenWeekday()
            {
                var daysTillHalloween = (new DateTime(DateTime.Now.Year, 10, 31) - DateTime.Now).TotalDays;
                double avrunda = Math.Floor(daysTillHalloween);
                Console.WriteLine($"It's {avrunda} days left till Hallowwen");
            }

            HalloweenWeekday();

            // Övning 3 - Mitt egna sätt att svara på

            var hugoDatum = new DateTime(1993, 10, 03);
            var hugoSkapades = hugoDatum.AddMonths(-9);

            void ConcepcionDay() 
            {
                Console.WriteLine("Född: " + hugoDatum);
                Console.WriteLine("Skapades: " + hugoSkapades);
            }

            ConcepcionDay();

            /*

            // Övning 3 FACIT - Funkar inte alls för mig om jag kopierar in??

            var birthday = new DateTime(1993, 10, 03); // Antar att detta ska stå med, men finns inte i facit??
            var concepcion = birthday.AddMonths(-9);   // Samma här

            void ConcepcionDayFacit(DateTime birthday)   
                                
            {
                Console.WriteLine("Född : " + birthday.ToString("dd MMM yyyy"));             
                Console.WriteLine("Befruktningsdatum : " + concepcion.ToString("dd MMM yyyy"));

            }

            ConcepcionDayFacit();

            */

            // Övning 4 - Mitt sätt

            var today = DateTime.Now.ToString("dd MMM yyyy");
            var dagNummer = new DateTime(DateTime.Now.Year, 9, 8).DayOfYear;           
            var veckodag = new DateTime(DateTime.Now.Year, 9, 8).DayOfWeek;            

            void TodayInfo()
            {
                Console.WriteLine("Datum : " + today);
                Console.WriteLine("Nummer : " + dagNummer);
                Console.WriteLine("Veckodag : " + veckodag);
                // Console.WriteLine("Sommartid : " + today.IsDaylightSavingTime()); // Funkar inte för mig om jag inte har detta överst i metoden:  var today = DateTime.Now; ??
                Console.WriteLine("Skottår : " + DateTime.IsLeapYear(DateTime.Now.Year));
            }

            TodayInfo();


            // Övning 4 - Facit

            TodayInfoFacit();

            void TodayInfoFacit()   
            {
                var today = DateTime.Now;
                Console.WriteLine("Datum : " + today.ToString("dd MMM yyyy"));
                Console.WriteLine("Nummer : " + today.DayOfYear);
                Console.WriteLine("Veckodag : " + today.DayOfWeek.ToString()); // Hur funkar ToString() här om man inte deklarerar hur man vill att det skall stå?
                Console.WriteLine("Sommartid : " + today.IsDaylightSavingTime());
                Console.WriteLine("Skottår : " + DateTime.IsLeapYear(DateTime.Now.Year));
            }


        }
    }
}
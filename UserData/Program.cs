using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolist;
            //toint32 konventeerib numbriks ehk arvuks, et ta mahuks int muutuja sisse

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation - võimaldab kirjutada täislauset ja sisestada sinna muutujat otseselt, ilma et sisestada + kasutada

            Console.WriteLine($"Oled {userAge} aastat vana");

           //NB: Console.WriteLine($"Oled userAge aastat vana") kuvab mulle täpselt sellise teksti:"oled userAge aastat vana"
           // See ei ole õige, korrektse jaoks on vaja kirjutada loogilised sulud {userAge} ümber
           // võib kasutada mõlemat varianti + või $ viisi, oleneb eelistusest. 




        }
    }
}

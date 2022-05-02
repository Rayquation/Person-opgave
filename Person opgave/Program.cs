using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1=new Person("Lars","Larsen",160,70);
            Person p2 = new Person("Mark", "Mikkelsen");
            Person p3 = new Person();
            p2.Højde = 180;
            p2.Vægt = 61;
            p3.Fornavn = "Oliver";
            p3.Efternavn = "Laursen";
            p3.Højde = 180;
            p3.Vægt = 60;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


            Person[] array = new Person[3];
            array[0] = p1;
            array[1] = p2;
            array[2] = p3;
            Console.WriteLine("*******************************************************************");


            Console.WriteLine("Unsorted");
            foreach (Person p in array)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("*******************************************************************");


            Array.Sort(array);
            Console.WriteLine("Sorted");
            foreach (Person p in array)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("*******************************************************************");
            Elev e1 = new Elev(StøjEnum.Stille,"Datateknikker",false,p1);
            Elev e2 = new Elev(StøjEnum.Høj, "Elektriker", true, p2);
            Elev e3 = new Elev(StøjEnum.Selv_Døve_Kan_Høre_Dig, "Mekaniker", false, p3);
            Elev[] elever = new Elev[3];
            elever[0] = e1;
            elever[1] = e2;
            elever[2] = e3;
            foreach (Elev i in elever)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

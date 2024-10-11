using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napszakok
{
    internal class Program
    {
        public static void udvozol()
        {
            DateTime ido = DateTime.Now;
            Console.WriteLine(ido.ToString());
            if (0 <= ido.Hour && ido.Hour >= 9) {
                Console.WriteLine("jó reggelt");
            }
            else if (10 <= ido.Hour && ido.Hour >= 12) {
                Console.WriteLine("szép napot");
            }
            else if (12 <= ido.Hour && ido.Hour >= 16) {
                Console.WriteLine("jó déutánt");
            }
            else if (17 <= ido.Hour && ido.Hour >= 19)
            {
                Console.WriteLine("szép estét");
            }
            else if (20 <= ido.Hour && ido.Hour >= 24)
            {
                Console.WriteLine("jó éjszakát");
            }
            Console.ReadKey();
        }
        public static Double kamat()
        {
            double kamatozas;
            Console.Write("mennyi időre szeretnéd ezt a pénzt be tenni(add meg években): ");
            int kamatido =Convert.ToInt32(Console.ReadLine());
            Console.Write("mekkora összeget szeretnél be venni: ");
            int kamatosszeg =Convert.ToInt32(Console.ReadLine());
            Console.Write("mekkora a kamat százaléka: ");
            int kamat =Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kamatido;i++) 
            {
               kamatozas = (kamatosszeg / kamat)*100 + kamatosszeg;
            }
            Console.WriteLine(" {0} FT-t van a számládon {1} évnyi kamatozás után",kamatozas,kamatido);
          return kamatozas;




        }
        public static void futas()
        {

        }
        static void Main(string[] args)
        {
           // udvozol();
            kamat(); 
            futas();
        }
    }
}

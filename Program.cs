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
        public static void kamat()
        {

        }
        public static void futas()
        {

        }
        static void Main(string[] args)
        {
            udvozol();
            kamat(); 
            futas();
        }
    }
}

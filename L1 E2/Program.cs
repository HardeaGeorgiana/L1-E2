using System;

namespace L1_E2
{
    class Program
    {
        /*E2. Scrieti un program care va calcula media aritmetica 
              a trei numere citite de la tastatura 
        */
        static void Main(string[] args)
        {
          int primulNumaru;
          int alDoileaNumar;
          int alTraileaNumar;

            Console.WriteLine("Introduceti primul numar");
            primulNumaru = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            alDoileaNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            alTraileaNumar = int.Parse(Console.ReadLine());

            int medieAritmetica = (primulNumaru + alDoileaNumar + alTraileaNumar) / 3;
            Console.WriteLine("Media aritmetica a celor trei numere este:" + medieAritmetica);
        }
    }
}

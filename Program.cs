using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendionsIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 32;
            int[] tableauEntier = new int[] { 25, 2, 6, 1, 2, 5, 4, 12223200 };

            double moyenneTableau ;
            Console.WriteLine(" Tableau initial  " );
            foreach (int num in tableauEntier)
                Console.Write(" " + num  );
            Console.WriteLine();

            Console.WriteLine(" Le programme fait la moyenne des éléments d'un tableau d'entiers pour tout élément inférieur ou égal à un entier n.");
            Console.WriteLine(" Choisissez la valeur de n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("______");

            Console.WriteLine("Nouveau tableau sans les nombre inférieur a " + n);

            foreach (int num in tableauEntier.Where(num => num < n))
                Console.Write(" " + num  );


            moyenneTableau = tableauEntier.Where(num => num < n).Average();
            Console.WriteLine();
            Console.WriteLine("Moyenne des valeurs inférieur à " + n +" : "+ moyenneTableau);

            Console.Read();
        }
    }
}

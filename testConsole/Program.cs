using System;

/**
 * Jeu du nombre caché
 * author : Théo
 * date : 13/30/21
 */

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice22

            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;
            int moyenne = 0, pasMoyenne = 0;

            Console.Write("Veuillez entrer 10 notes: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n5 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n6 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n7 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n8 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n9 = int.Parse(Console.ReadLine());
            Console.Write(": ");
            n10 = int.Parse(Console.ReadLine());

            switch (n1, n2, n3, n4, n5, n6, n7, n8, n9, n10)
            {
                case < 10:
                    pasMoyenne++;
                    break;
                case >= 10:
                    moyenne++;
                    break;
            }

            Console.WriteLine("Vous avez " + pasMoyenne + " notes en dessous de la moyenne et " + moyenne + " " +
                "notes au-dessus de la moyenne ou égale(s) à la moyenne.");



            Console.ReadLine();


            

        }
    }
}
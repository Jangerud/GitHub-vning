using System;
using System.Linq;

namespace GitHubÖvning
{
    class Program
    {
        static void Main(string[] args)
        {

            //CTRL + K, CTRL + D gör att allt tabbas så det ligger snyggt.
            //int[] arrayOfNumbers = new int[5];
            //arrayOfNumbers[0] = 13;
            //arrayOfNumbers[1] = 22;
            //arrayOfNumbers[2] = 3;
            //arrayOfNumbers[3] = 93;
            //arrayOfNumbers[4] = 1;

            //Console.WriteLine("Check if you picked the lucky number!");
            //string nr = Console.ReadLine();
            //int myNr = Convert.ToInt32(nr);


            /*For loopen har 3 värden, Först startvärdet (int i = 0)
             * Sedan kommer "argumentet" (i < length) alltså hur länge ska vi loopa igenom.
             * Sist kommer handlingen/hanteringen av första värdet.
             */
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    if (myNr == arrayOfNumbers[i])
            //    {
            //        Console.WriteLine("Winner winner chicked dinner!");

            //    } else
            //    {
            //        Console.WriteLine("Not this time, sport!");
            //    }


            //}

            //Övning 2
            //1. Alternativet

            int[] firstArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondArray = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));

            Console.WriteLine(string.Join(',', firstArray.Reverse()));

        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace numbersay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = numbers.Sum();
            //Console.WriteLine(sum);



            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 4; i <= numbers.Length; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int a = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) 
            //    {
            //        a += numbers[i];
            //    }
            //}

            //Console.WriteLine(a);




            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        sum += numbers[i];
            //    }
            //}

            //Console.WriteLine(sum);



            //int[] numbers = { 5, 10, 15, 20, 25 };
            //int a = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 5 == 0)
            //    {
            //        a += numbers[i];
            //    }
            //}

            //Console.WriteLine(a);


            //int[] numbers = { 3, 7, 2, 9, 4, 6, 8, 1, 5 };
            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);








            //int[] numbers = { 5, 2, 10, 8, 3, 1 };
            //int maxIndex = 0;
            //int minIndex = 0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > numbers[maxIndex])
            //    {
            //        maxIndex = i;

            //    }

            //    else if (numbers[i] < numbers[minIndex])
            //    {
            //        minIndex = i;

            //    }

            //    Console.WriteLine(maxIndex);
            //    Console.WriteLine(minIndex);

            //}




            int[] numbers = { 1, 2, 3, 4, 5 };
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            int average = total / numbers.Length;

            Console.WriteLine(average);





            //int[] numbers = { 1, 2, 3, 4, 5 };
            //bool inOrder = true;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < numbers[i - 1])
            //    {
            //        inOrder = false;
            //        break;
            //    }
            //}

            //if (inOrder)
            //{
            //    Console.WriteLine("Sıra ilədir");
            //}
            //else
            //{
            //    Console.WriteLine("Sıra ilə deyil");
            //}






            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 5, 6, 7, 8, 9 };
            //bool ifFound = false;

            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    for (int j = 0; j < numbers2.Length; j++)
            //    {
            //        if (numbers1[i] == numbers2[j])
            //        {
            //            ifFound = true;
            //            break;
            //        }
            //    }
            //    if (!ifFound)
            //    {
            //        Console.WriteLine(false);
            //        break;
            //    }
            //}


            //int[] numbers = { 1, 2, 34, 21, 4, 6, 8 };

            //int a = numbers[2];
            //numbers[2] = numbers[6];
            //numbers[6] = a;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //int[] numbers = { 2, 3, 4, 5 };

            //int i = 0;
            //int total = 0;
            //for (i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine(total);



















        }
    }
}
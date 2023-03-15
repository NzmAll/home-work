using System.ComponentModel.Design;

namespace arrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Daxil edilen stringin her bir characterini ekrana cixarilmasi
            //string name = "Nizami";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letter = name[i];
            //    Console.WriteLine(name[i]);
            //}





            //Daxil  edilen stringin daxilinde reqem olub olmadigi?
            char[] letter = new char[0];
            int[] name = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == )
                {
                    Console.WriteLine("Reqem var");
                    break;
                }
                else
                {
                    Console.WriteLine("Reqem yoxdur");
                }
            }




            //Daxil edilen stringin arxadan qabaga ekrana yazilmasi
            //string name = "Nizami123";

            //for (int i = 8; i < name.Length; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}





            //Daxil edilen cumlede her bir sozu ekrana cixarsin
            //string sentence = "Salam menim adim Nizamidir";
            //string[] letter = sentence.Split(' ');

            //for (int i = 0; i < letter.Length; i++)
            //{
            //    Console.WriteLine(letter[i]);
            //}





            //Reqemin tersine cevrilmesi
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 4; i < numbers.Length; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}








        }
    }
}
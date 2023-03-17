namespace arrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Daxil edilen stringin her bir characterini ekrana cixarilmasi

            //string name = "Nizami";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letter = name[i];
            //    Console.WriteLine(name[i]);
            //}





            //2. Daxil  edilen stringin daxilinde reqem olub olmadigi?

            //string letter = "Salam menim adim 8 Nizamidir";

            //for (int i = 0; i < letter.Length; i++)
            //{
            //    if (letter[i] == '0' || letter[i] == '1' || letter[i] == '2' || letter[i] == '3' || letter[i] == '4' || letter[i] == '5' ||
            //        letter[i] == '6' || letter[i] == '7' || letter[i] == '8' || letter[i] == '9')
            //    {
            //        Console.WriteLine("reqem var");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("reqem yoxdur");
            //        break;
            //    }
            //}





            //4. Daxil edilen stringin arxadan qabaga ekrana yazilmasi

            //string name = "Nizami123";

            //for (int i = 8; i < name.Length; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}





            //5. Daxil edilen cumlede her bir sozu ekrana cixarsin

            //string sentence = "Salam menim adim Nizamidir";
            //string[] letter = sentence.Split(' ');

            //for (int i = 0; i < letter.Length; i++)
            //{
            //    Console.WriteLine(letter[i]);
            //}





            //6. Reqemin tersine cevrilmesi

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 4; i < numbers.Length; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}








            //7. Reqemin polindrom olub-olmamasi

            //int[] numbers = { 1, 2, 3 };
            //int[] number = { 3, 2, 1 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == number[numbers.Length - i - 1])
            //    {
            //        Console.WriteLine("Palindromdur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Palindrom deil");

            //    }
            //}




            //9. string daxilinde spacelerin silinmesi

            //string sentence = "Salam menim adim Nizamidir";
            //string result = "";
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] != ' ')
            //    {
            //        result += sentence[i];
            //    }
            //}
            //Console.WriteLine(result);






            //her hansi bir reqemin int daxilinde tekrar olub olmadigi

            //int[] numbers = { 1, 2, 3, 3, 5 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            Console.WriteLine("Tekrar var");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tekrar yoxdur");
            //            break;
            //        }
            //    }
            //}








            //13. Verilen nomre +994 ile baslayib baslamadigini yoxlamaq

            //string number = "+994504068306";


            //if (number[0] == '+' && number[1] == '9' && number[2] == '9' && number[3] == '4')
            //{
            //    Console.WriteLine("Nomre +994 ile baslayir");
            //}

            //else
            //{
            //    Console.WriteLine("Nese sehv var");
            //}





            //12. Verilen stringin daxilinden butun reqemleri silsin

            //string sentence = "Salam menim adim N6izamidir";
            //string result = "";
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == '0' || sentence[i] == '1' || sentence[i] == '2' || sentence[i] == '3' ||
            //        sentence[i] == '4' || sentence[i] == '5' || sentence[i] == '6' || sentence[i] == '7' ||
            //        sentence[i] == '8' || sentence[i] == '9')
            //    {
            //        continue;
            //    }
            //        result += sentence[i];
            //}
            //Console.WriteLine(result);





            //3. Daxil edilen stringin daxilinde herf olub-olmamasi

            //char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //string name = "23567";
            //bool isTrue = true;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int j = 0; j < uppercaseLetters.Length; j++)
            //    {
            //        if (name[i] == uppercaseLetters[j] || name[i] == lowerLetters[j])
            //        {
            //            isTrue = false;
            //        }
            //    }
            //}

            //if (isTrue == true)
            //{
            //    Console.WriteLine("herf yoxdur");
            //}
            //else if (isTrue == false)
            //{
            //    Console.WriteLine("herf var");



            //14. Her hansi bir stringin basqa bir stringin daxilinde olub olmadigini yoxlamaq

            int[] numbers = { 1, 2, 3, 3, 5 };
            int[] numbers2 = { 3, 2, 3, 5 };

            bool containsAllNumbers = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool foundNumber = false;
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers[i] == numbers2[j])
                    {
                        foundNumber = true;
                        
                    }
                }

                if (!foundNumber)
                {
                    containsAllNumbers = false;
                    break;
                }
            }

            if (containsAllNumbers)
            {
                Console.WriteLine("eyni eded var");
            }
            else
            {
                Console.WriteLine("yoxdur");
            }












        
        }
    }
}

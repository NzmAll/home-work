namespace arrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Daxil edilen stringin her bir characterini ekrana cixarilmasi

            //Console.Write("Adi daxil edin: ");
            //string name = Convert.ToString(Console.ReadLine()!);

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}





            //2. Daxil  edilen stringin daxilinde reqem olub olmadigi?

            //    char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //    Console.Write("Adi daxil edin: ");
            //    string name = Convert.ToString(Console.ReadLine()!);
            //    bool isTrue = true;

            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        for (int j = 0; j < numbers.Length; j++)
            //        {
            //            if (name[i] == numbers[j])
            //            {
            //                isTrue = false;
            //            }
            //        }
            //    }

            //    if (isTrue == true)
            //    {
            //        Console.WriteLine("Reqem yoxdur");
            //    }
            //    else if (isTrue == false)
            //    {
            //        Console.WriteLine("Reqem var");
            //    }
            //}






            //3. Daxil edilen stringin daxilinde herf olub-olmamasi

            //char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Console.Write("Stringi daxil edin: ");
            //string name = Convert.ToString(Console.ReadLine()!);
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
            //}



            //4. Daxil edilen stringin arxadan qabaga ekrana yazilmasi

            //Console.Write("Adi daxil edin: ");
            //string name = Convert.ToString(Console.ReadLine()!);
            //string result = "";

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    result += name[i];
            //}
            //Console.WriteLine(result);







            //5. Daxil edilen cumlede her bir sozu ekrana cixarsin

            //Console.Write("Adi daxil edin: ");
            //string sentence = Convert.ToString(Console.ReadLine()!);
            //string letter = "";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        Console.WriteLine(letter);
            //        letter = "";
            //    }
            //    else
            //    {
            //        letter += sentence[i];
            //    }
            //}

            //Console.WriteLine(letter);






            //6. Reqemin tersine cevrilmesi

            //Console.Write("Ededi daxil edin: ");
            //string numbers = Convert.ToString(Console.ReadLine()!);

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i]);
            //}








            //7. Reqemin polindrom olub-olmamasi

            //Console.Write("1-ci stringi daxil edin: ");
            //String numbers = Convert.ToString(Console.ReadLine()!);

            //Console.WriteLine("2-ci stringi daxil edin: ");
            //String number = Convert.ToString(Console.ReadLine()!);

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




            //9. String daxilinde spacelerin silinmesi

            //Console.Write("Stringi daxil edin: ");
            //string sentence = Convert.ToString(Console.ReadLine()!);
            //string result = "";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] != ' ')
            //    {
            //        result += sentence[i];
            //    }
            //}
            //Console.WriteLine(result);






            //Her hansi bir reqemin int daxilinde tekrar olub olmadigi

            //Console.Write("Int-i daxil edin: ");
            //String numbers = Convert.ToString(Console.ReadLine()!);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
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

            //Console.Write("Nomreni daxil edin: ");
            //string number = Convert.ToString(Console.ReadLine()!);


            //if (number[0] == '+' && number[1] == '9' && number[2] == '9' && number[3] == '4')
            //{
            //    Console.WriteLine("Nomre +994 ile baslayir");
            //}

            //else
            //{
            //    Console.WriteLine("Nese sehv var");
            //}





            //12. Verilen stringin daxilinden butun reqemleri silsin

            //Console.Write("Cumleni daxil edin: ");
            //string sentence = Convert.ToString(Console.ReadLine()!);
            //string result = "";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == '0' || sentence[i] == '1' || sentence[i] == '2' || sentence[i] == '3' ||
            //        sentence[i] == '4' || sentence[i] == '5' || sentence[i] == '6' || sentence[i] == '7' ||
            //        sentence[i] == '8' || sentence[i] == '9')
            //    {
            //        continue;
            //    }
            //    result += sentence[i];
            //}
            //Console.WriteLine(result);









            //14. Her hansi bir stringin basqa bir stringin daxilinde olub olmadigini yoxlamaq

            //Console.Write("1-ci stringi daxil edin: ");
            //string numbers = Convert.ToString(Console.ReadLine()!);

            //Console.Write("2-ci stringi daxil edin: ");
            //string number = Convert.ToString(Console.ReadLine()!);

            //bool containsAllNumbers = true;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    bool foundNumber = false;
            //    for (int j = 0; j < number.Length; j++)
            //    {
            //        if (numbers[i] == number[j])
            //        {
            //            foundNumber = true;
            //        }
            //    }

            //    if (!foundNumber)
            //    {
            //        containsAllNumbers = false;
            //        break;
            //    }
            //}

            //if (containsAllNumbers)
            //{
            //    Console.WriteLine("eyni eded var");
            //}
            //else
            //{
            //    Console.WriteLine("yoxdur");
            //}



        }
    }
}

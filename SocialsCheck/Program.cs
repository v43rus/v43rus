using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Personnr_Kontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool programIsRunning = true;


            while (programIsRunning)
            {

                string socialNumber = "";
                bool tryOne = true;
                // Failsafe as long as person doesn't input anything
                do
                {
                    if (tryOne)
                    {
                        Console.Clear();
                        Console.Write("Skriv in ditt personnr i format ÅÅMMDDXXXX: ");
                        socialNumber = Console.ReadLine();
                        tryOne = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Programmet kräver en input! ");
                        Console.Write("Skriv in ditt personnr i format ÅÅMMDDXXXX: ");
                        socialNumber = Console.ReadLine();
                        tryOne = false;
                    }
                }
                while (socialNumber == "");

                socialsValidator(socialNumber);
            }
        }

        static void socialsValidator(string input)
        {
            // Tar bort mellanslag och bindestreck i listan
            input = input.Replace("-", "").Replace(" ", "");

            // Skapar lista och sättar input i den
            List<char> charList = new List<char>();
            charList.AddRange(input);

            // Kontrollerar längden så den är rätt formaterad
            if (charList.Count == 10)
            {
                Console.WriteLine("Your socials is correctly formatted");
                Console.WriteLine("Click a button to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your social number isn't correctly formatted");
                Console.WriteLine("Click a button to input a valid social");
                Console.ReadKey();
                return;
            }

            // Säkerställer att alla inputs är siffror
            bool isNr = true;

            for (int i = 0; i < charList.Count; i++)
            {
                if (!Char.IsDigit(charList[i]))
                {
                    isNr = false;
                }
            }

            if (isNr)
            {
                Console.WriteLine("Your social number only contains numbers");
                Console.WriteLine("Click a button to input a valid social");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your social number should only contain numbers");
                Console.WriteLine("Click a button to input a valid social");
                Console.ReadKey();
                return;
            }

            // Beräkna kontrollsiffran och jämför den med den givna kontrollsiffran
            int lastNumber = CalculateLastNumber(charList);

            string tempString = lastNumber.ToString();
            List<char> tempList = new List<char>();
            tempList.AddRange(tempString);

            if (charList[charList.Count - 1] == tempList[0])
            {
                Console.WriteLine("Your social number is valid");
                Console.WriteLine("Click a button to input another social");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("The last number of your socials don't match");
                Console.WriteLine("Click a button to input a valid social");
                Console.ReadKey();
                return;
            }


        }

        static int CalculateLastNumber(List<char> inputList)
        {
            List<int> intList = new List<int>();

            foreach (char c in inputList)
            {
                intList.Add(int.Parse(c.ToString()));
            }

            int result = 0;

            for (int i = 0; i < 9; i++)
            {
                int tempInt = 0;


                if (i % 2 == 0)
                {
                    tempInt = intList[i] * 2;
                }
                else
                {
                    tempInt = intList[i];
                }

                if (tempInt == 10)
                {
                    tempInt = 1;
                }
                else if (tempInt > 10)
                {
                    string tempString = tempInt.ToString();
                    List<char> tempList = new List<char>();
                    tempList.AddRange(tempString);

                    tempInt = 0;

                    foreach (char c in tempList)
                    {
                        tempInt += int.Parse(c.ToString());
                    }
                }
                result += tempInt;
            }

            result = 10 - (result % 10);
            return result;
        }
    }
}
using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust


            Console.WriteLine("Sisesta oma eesnime:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali numbrit 1 kuni 3");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    GetUserName1(userName);
                    break;
                case 2:
                    GetUserName2(userName);
                    break;
                case 3:
                    GetUserName3(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void GetUserName1(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }           
        }

        public static void GetUserName2(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void GetUserName3(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümboli pikk.");
        }

    }
}

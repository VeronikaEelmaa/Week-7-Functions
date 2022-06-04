using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi;
            //programm küsib kasutajal sisestada number 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimene täht;
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("palun sisesta oma eesnimi:");
            string userName = Console.ReadLine();
                      
            Console.WriteLine("sisesta number 1-3");
            
            char userOperator = Convert.ToChar(Console.ReadLine());
            
            switch (userOperator)
            {
                case '1':
                    ReverseUserNameData(userName);
                    break;
                case '2':
                    FirstSymbolUserNameData(userName);
                    break;
                case '3':
                    LengthUserNameData(userName);
                    break;
                default:
                    Console.WriteLine("Seda valikut kahjuks polnud! Kena päeva!");
                    break;
            }


        }
        public static void LengthUserNameData(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk.");
        }       
        public static void ReverseUserNameData(string userName)
        {
           for (int i = userName.Length - 1; i >= 0; i--)
           {
                Console.Write(userName[i]);
           } 
        }
        public static void FirstSymbolUserNameData(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}.");
        }


    }
}

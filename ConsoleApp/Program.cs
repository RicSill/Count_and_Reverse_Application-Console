using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BENVENUTO/A! \nCosa vuoi fare? \n");

            Menu();
            
           

            
            
            //if (i == 1)
            //{

            //}
            //else if(i == 2)
            //{

            //}
            //else if(i == 3)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Scegli un numero da 1 a 3!")
            //}



        }
        public static void Menu()
        {
            Console.WriteLine("\n1. Vedere una frase al contrario \n2. Sapere il numero di parole di una frase \n3. Sapere il numero di caratteri \n9. Uscire dalla Console");
            try {
                var i = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Digitare la frase");
                switch (i)
                {
                    case 1:
                       
                        ReversePhrase();
                        break;
                    case 2:
                        CountWords();
                        break;
                    case 3:
                        CountLetters();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Selezionare un numero che sia 1 2 o 3");
                        Menu();
                        break;
                            



                }
            }
            catch { Console.WriteLine("Selezionare un numero!"); }
             Menu();
        }

        public static void ReversePhrase()
        {
            var s = Console.ReadLine();
            string reverseString = string.Empty;
         
            for (int i = s.Length - 1; i >= 0; i--)
            {
                 reverseString += s[i];
            }

            Console.Write($"Ecco la tua parola/frase al contrario: \n\n{reverseString} \n\nPremere 'INVIO' per richiamare il Menù\n");
            Console.ReadLine();
        }
        public static void CountWords()
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');
            Console.WriteLine($"Numero di parole:\n\n{words.Length} \n\nPremere 'INVIO' per richiamare il Menù\n");
            Console.ReadLine();
        }

        public static void CountLetters()
        {
            string phrase = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (!char.IsWhiteSpace(phrase[i]))
                {
                    count++;
                }
            }

            Console.WriteLine($"Totale caratteri:\n\n{count} \n\nPremere 'INVIO' per richiamare il Menù\n");
            Console.ReadLine();
        }
    }
}

    // Scrivere una parola, poi invertire i caratteri e contare parole in input
    // SPLIT
    //FOR DA 0 A N-1
   


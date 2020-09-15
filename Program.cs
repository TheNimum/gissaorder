using System;

namespace gissaorder
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "hello";
            string guesseword = "";
            int guess = 0;
            int guessmax = 3;
            bool outofguess = false;
                while (guesseword !=secretword && !outofguess)
                {
                    if ( guess < guessmax)
                    {
                        Console.Write("skriv det hemliga ordet.: ");
                        guesseword = Console.ReadLine();
                        guess++;
                    }else 
                    {
                        outofguess = true;
                    }
                  }  
                    if(outofguess)
                    {
                       Console.WriteLine("du förlorade :("); 
                    }
                    else
                    {
                        Console.WriteLine("korrekt ! :)");
                    }
                
        }
    }
}

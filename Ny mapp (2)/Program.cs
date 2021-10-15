using System;

namespace Ny_mapp__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
               
                int numback = random.Next(1, 100);
                
                int person = 23;

                int försök = 0;

                Console.WriteLine("Jag tänker på en nummer mellan 1-100, du får vinna 100M i fall du gissar.");

                
                    while(person != numback)
                    {
                        
                        person = Convert.ToInt32(Console.ReadLine());

                        if(person < numback)
                       {
                            Console.WriteLine("Nop, nummert du hade sagt är för lågt nu.");
                            Console.WriteLine("Testar igen!");
                            försök+= 1;
                        }
                        else if (person > numback)
                         {
                            Console.WriteLine("Nehej du, nummert du skrev är för höjd.");
                            Console.WriteLine("Du får gissar igen!");
                            försök+= 1;
                        }
                    }
                    Console.WriteLine("Äntligen, bra jobbat");
                    Console.Write("Du försökte så många gånger ");
                    Console.Write(försök);
                    Console.ReadLine();

        }
    }
}

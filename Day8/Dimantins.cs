using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Dimantins
    {
        public static void Dimants()
        {
            
            Console.Write("Ievadi rindu skaitu N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int rinda = 1; rinda <= n; rinda++)
            {
                
                for (int spogulisK = 1; spogulisK <= n-rinda; spogulisK++)
                {
                    Console.Write(" ");
                }
                for (int kolona = 1; kolona<= rinda; kolona++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             
            for (int rinda = 1; rinda <= n-1; rinda++)
            {
                

                for (int spogulisK = 1; spogulisK <= rinda; spogulisK++)
                {
                    Console.Write(" ");
                }
                for (int kolona = n-1; kolona >= rinda; kolona--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
    
}

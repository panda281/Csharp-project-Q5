using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int x=2;x<100;x++)
            {
               if(x%2==0)
                {
                    Console.Write(x + ", ");
                }
               else
                {
                    Console.Write(x * -1 + ", ");
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classessss
{
    public class Diamond
    {
        int num;
       

        public void pattern(int num)
        {
            this.num = num; 

            for(int i = 1; i <= num; i++)
            {
                for(int j=1; j <= num*2-1; j++)
                {
                    if (j>=num+1-i &&  j<=num-1+i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                
                Console.Write("\n");
            }
            
        }

    }
}

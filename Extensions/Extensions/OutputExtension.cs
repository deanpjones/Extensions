using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Extensions
{
    public static class OutputExtension
    {
        //TODO 
        //PRINT ARRAY OR LIST 
        //PRINT SO IT DISPLAY IT ON A SINGLE LINE (LIKE CHAR VS STRING)

        //PRINT TO CONSOLE
        public static void PrintToConsole(this List<int> list)
        {
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}

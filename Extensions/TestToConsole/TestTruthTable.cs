using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.TestToConsole
{
    public static class TestTruthTable
    {
        public static void Test()
        {
            Extensions.TruthTable logic = new Extensions.TruthTable();
            logic.Elements = new int[] { 2, 3 };
            logic.CreateArray();
        }
    }
}

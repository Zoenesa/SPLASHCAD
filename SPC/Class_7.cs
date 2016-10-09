using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Autodesk.AutoCAD.Runtime.CommandClass(typeof(SPC.Class_7))]
namespace SPC
{
    [Microsoft.VisualBasic.CompilerServices.StandardModule]
    internal sealed class Class_7
    {
        public static decimal decimal_0 = 0.000000000001M;
        public static decimal decimal_1 = decimal.Multiply(decimal_0, 1000M);
        public static decimal decimal_2 = decimal.Multiply(decimal_1, 1000M);
        public static string string_0 = "en";

    }
}

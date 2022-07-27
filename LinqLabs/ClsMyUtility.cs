using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabs
{
    class ClsMyUtility:Object
    {
      internal static  int Mutiply (int n1, int n2)
        {
            return n1 * n2;
        }

      internal  static void Swap(ref int n1, ref int n2)
        {
            int temp = n2;
            n2 = n1;
            n1 = temp;
        }

       internal   static void Swap(ref string n1, ref string n2)
        {
            string temp = n2;
            n2 = n1;
            n1 = temp;
        }

        static void Swap(ref Point n1, ref Point n2)
        {
            Point temp = n2;
            n2 = n1;
            n1 = temp;
        }
      internal   static void SwapAnyType<T>(ref T n1, ref T n2)
        {
            T temp = n2;
            n2 = n1;
            n1 = temp;
        }
    }
}

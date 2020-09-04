using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy.MVVM.Extensions
{
    public static class IsEvenExtension
    {
        public static bool IsEven(this int value)
        {
            return value % 2 == 0 ? true : false;
        }
    }
}

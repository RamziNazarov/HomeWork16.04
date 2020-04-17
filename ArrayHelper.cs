using System;

namespace HomeWork._16._04
{
    static class ArrayHelper
    {
        public static T Pop<T>(ref T[] array)
        {
            T el = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return el;
        }
    }
}
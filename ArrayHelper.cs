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
        public static int Push<T> (ref T[] array, T el)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = el;
            return array.Length;
        }
        public static T Shift<T> (ref T[] array)
        {
            T el = array[0];
            Array.Reverse(array);
            Array.Resize(ref array, array.Length-1);
            Array.Reverse(array);
            return el;
        }
    }
}
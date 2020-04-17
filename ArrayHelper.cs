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
        public static int UnShift<T>(ref T[] array, T el)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length+1);
            Array.Reverse(array);
            array[0] = el;
            return array.Length;
        }
        public static T[] Slice<T>(T[] array,int beginIndex = 0, int endIndex = 0)
        {
            T[] arr;
            if(beginIndex>=0 && endIndex == 0&& beginIndex <= array.Length)
            {
                arr = new T[array.Length-beginIndex];
                for(int i =0; i < arr.Length;i++)
                {
                    arr[i] = array[beginIndex];
                    beginIndex++;
                }
                return arr;
            }
            else if (beginIndex> array.Length || endIndex > array.Length+1)
            {
                return arr = new T[0];
            }
            else if(beginIndex < 0)
            {
                int a = array.Length - (array.Length - Math.Abs(beginIndex));
                arr = new T[a];
                for(int i = 0; i < arr.Length;i++)
                {
                    arr[i] = array[array.Length - a];
                    a--;
                }
                return arr;
            }
            else if(endIndex < 0 && Math.Abs(endIndex) < array.Length)
            {
                arr = new T[array.Length - Math.Abs(endIndex)-beginIndex];
                for(int i =0; i< arr.Length;i++)
                {
                    arr[i] = array[beginIndex];
                    beginIndex++;
                }
                return arr;
            }
            else if(beginIndex < endIndex)
            {
                arr = new T[array.Length - beginIndex];
                for(int i = 0; i < arr.Length;i++)
                {
                    arr[i] = array[beginIndex];
                    beginIndex++;
                }
                return arr;
            }
            else return arr = new T[0];           
        }
    }
}
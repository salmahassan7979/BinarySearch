using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1,4,20,35,60,75,90};
            var index = Binarysearch(arr, 100);
            Console.WriteLine("Element Found index=", index);

        }
        public static int Binarysearch(int[] arr,int key)
        {
            int leftarray = 0;
            int rightarray = arr.Length;
            while (leftarray< rightarray)
            {
                int mid = (leftarray + rightarray) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    rightarray = mid;
                }
                else
                {
                    leftarray = mid + 1;
                }
            }
            return -1;
        }
    }
}

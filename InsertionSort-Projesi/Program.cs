using System;

namespace InsertionSort_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //[22,27,16,2,18,6]-> Insertion Sort
            //1->Siralama asamalari
            //    1-22,27,16,2,18,6
            //    2-16,22,27,2,18,6
            //    3-2,16,22,27,18,6
            //    4-2,16,18,22,27,6
            //    5-2,6,16,18,22,27
            
            //2->Big O(n^2)

            //3->Time Complexity
            //   Best case:16
            //   Average case:2
            //   Worst case:6

            //4->Dizi siralandiktan sonra 18 sayisi average case kapsamina girer.

            //5->[7,3,5,8,2,9,4,15,6]
            //    1-7,3,5,8,2,9,4,15,6
            //    2-3,7,5,8,2,9,4,15,6
            //    3-3,5,7,8,2,9,4,15,6
            //    4-3,5,7,8,2,9,4,15,6
            //    5-2,3,5,7,8,9,4,15,6

        }
    }
}

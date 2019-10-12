using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapInsertLab
{
    class HeapInsertLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size for the heap:  ");
            int max_size = Int32.Parse(Console.ReadLine());
            MaxHeap maxHeap = new MaxHeap(max_size);

            for (int i = 0; i < max_size; i++)
            {
                Console.WriteLine("\nEnter a string to be entered into the heap:  ");
                maxHeap.Insert(Console.ReadLine());
            }

            maxHeap.HeapSort();
            maxHeap.Print();
            Console.ReadLine();
        }
    }
}

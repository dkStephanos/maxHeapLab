using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapInsertLab
{
    class MaxHeap
    {
        private int max_size;           //max size of heap, this is included just to explain that size is not maximum size, but is current heap size.
        private int size;               //size of current heap
        private string[] h;             //array of strings that the heap will use

        public MaxHeap(int total_size)
        {
            this.max_size = total_size + 1;
            this.size = 0;
            this.h = new String[this.max_size];
        }

        public void Print()
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(h[i]);
            }
        }

        public void Insert(String item)
        {
            this.h[++size] = item;
            int current_index = size;

            while (0 < String.Compare(this.h[current_index], this.h[current_index/2], StringComparison.Ordinal))
            {
                this.h[0] = this.h[current_index];
                this.h[current_index] = this.h[current_index / 2];
                this.h[current_index / 2] = h[0];
                current_index = current_index / 2;
            }
        }
    }
}

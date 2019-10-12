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
            for (int i = 1; i < h.Length; i++)
            {
                Console.Write(h[i] + " ");
            }
            Console.WriteLine();
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

        public string ExtractMax()
        {
            this.h[0] = this.h[this.size];
            this.h[this.size] = this.h[1];
            this.h[1] = this.h[0];
            this.size--;

            MaxHeapify(1);

            return this.h[this.size];
        }

        public void MaxHeapify(int current_index)
        {
            int max = current_index;
            int left = current_index * 2;
            int right = current_index * 2 + 1;

            if (left <= this.size && 0 > String.Compare(this.h[current_index], this.h[left], StringComparison.Ordinal))
            {
                max = left;
            }
            else if (right <= this.size && 0 > String.Compare(this.h[max], this.h[right], StringComparison.Ordinal))
            {
                max = right;
            }
            if (max != current_index)
            {
                this.h[0] = this.h[current_index];
                this.h[current_index] = this.h[max];
                this.h[max] = h[0];
                current_index = max;
                MaxHeapify(max);
            }
           
        }

        public void HeapSort()
        {
            while (this.size > 1)
            {
                ExtractMax();
            }
        }
    }
}

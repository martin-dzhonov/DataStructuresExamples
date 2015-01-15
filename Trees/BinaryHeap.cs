using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryHeap<T> where T: IComparable<T>
    {
        private IComparer<T> comparer;
        private List<T> items = new List<T>();
        public BinaryHeap(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public void Clear()
        {
            this.items.Clear(); 
        }

        public void Insert(T value)
        {
            int i = this.Count;
            this.items.Add(value);
            while (i > 0 && this.comparer.Compare(this.items[(i - 1) / 2], value) > 0)
            {
                this.items[i] = items[(i - 1) / 2];
                i = (i - 1) / 2;
            }
            items[i] = value;
        }

        public T Peek()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty");
            }
            return this.items[0];
        }

        public T Pop()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty");
            }
            T root = this.items[0];
            T tmp = this.items[items.Count - 1];
            this.items.RemoveAt(items.Count - 1);
            if (this.items.Count > 0)
            {
                int i = 0;
                while (i < this.items.Count / 2)
                {
                    int j = (2 * i) + 1;
                    if ((j < this.items.Count - 1) && (this.comparer.Compare(this.items[j], this.items[j + 1]) > 0))
                    {
                        ++j;
                    }
                    if (this.comparer.Compare(this.items[j], tmp) >= 0)
                    {
                        break;
                    }
                    this.items[i] = this.items[j];
                    i = j;   
                }
                this.items[i] = tmp;
            }
            return root;
        }
    }
}

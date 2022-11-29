using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_types1
{
    internal class Generic1<T\                       >
    {
        private T[] arr;
        public Generic1()
        {
            arr = new T[0];
        }
        public void add(T ex)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = ex;
        }
        public T this[int i]
        {
            get
            {       
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
        public void Show()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

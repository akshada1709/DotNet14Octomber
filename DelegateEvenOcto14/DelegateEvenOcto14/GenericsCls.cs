using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvenOcto14
{
    public class GenericsCls<T>
    {
        private T data;
        public void Add(T data)
        {
            this.data = data;
        }

        public T Get()
        {
            return this.data;
        }
        //static void Main(string[] args)
        //{
           


        //}
    }
}

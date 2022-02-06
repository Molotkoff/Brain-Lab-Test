using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.Core
{
    public class Pool<T>
    {
        private Stack<T> pool = new Stack<T>();

        private Func<T> createFunc;

        public Pool(Func<T> createFunc)
        {
            this.createFunc = createFunc;
        }

        public T Item
        {
            get => pool.Count > 0 ? pool.Pop() : createFunc();
            set => pool.Push(value);
        }
    }
}
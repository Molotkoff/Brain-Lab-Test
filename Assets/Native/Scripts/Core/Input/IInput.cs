using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public interface IInput<T> : IEnable, IDisable
    {
        public event Action<T> Performed;
    }
}
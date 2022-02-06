using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public interface IHealthModel
    {
        public event Action<int> OnChangeValue;
        public event Action<int> OnChangeMaxValue;

        public int Value { get; set; }
        public int MaxValue { get; set; }
    }
}
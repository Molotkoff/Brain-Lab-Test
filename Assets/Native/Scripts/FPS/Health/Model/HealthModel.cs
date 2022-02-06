using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public class HealthModel : IHealthModel
    {
        public event Action<int> OnChangeValue;
        public event Action<int> OnChangeMaxValue;

        private int _value;
        private int _maxValue;

        public int Value 
        { 
            get => _value;
            set 
            {
                _value = value;
                OnChangeValue?.Invoke(value);
            }
        }

        public int MaxValue 
        { 
            get => _maxValue;
            set 
            {
                _maxValue = value;
                OnChangeMaxValue?.Invoke(value);
            } 
        }

        public HealthModel(int _value, int maxValue)
        {
            this._value = _value;
            this._maxValue = maxValue;
        }
    }
}
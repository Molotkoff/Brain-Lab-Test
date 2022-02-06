using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.BTree
{
    public class Throttle : ITree
    {
        public event Action OnEnable;
        public event Action OnDisable;

        private float time;
        private float currentTime;

        public Throttle(float time)
        {
            this.time = time;
        }

        public void Enable()
        {
            currentTime = 0;
            OnEnable?.Invoke();
        }

        public void Disable() => OnDisable?.Invoke();
        
        public TreeResult Execute(float time)
        {
            currentTime += time;

            if (currentTime >= this.time)
                return TreeResult.Success;

            return TreeResult.Running;
        }
    }
}
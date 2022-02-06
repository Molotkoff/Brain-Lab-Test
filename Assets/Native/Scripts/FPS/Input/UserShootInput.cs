using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Molotkoff.FPS
{
    public class UserShootInput : IInput<Vector2>
    {
        public event Action OnEnable;
        public event Action OnDisable;

        public event Action<Vector2> Performed;

        private InputScheme inputScheme;

        public UserShootInput(InputScheme inputScheme)
        {
            this.inputScheme = inputScheme;
        }

        public void Enable()
        {
            inputScheme.User.Shoot.Enable();
            OnEnable?.Invoke();
        }

        public void Disable()
        {
            inputScheme.User.Shoot.Disable();
            OnDisable?.Invoke();
        }
    }
}
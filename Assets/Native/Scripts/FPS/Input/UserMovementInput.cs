using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Molotkoff.FPS
{
    public class UserMovementInput : IInput<Vector2>
    {
        public event Action OnEnable;
        public event Action OnDisable;

        public event Action<Vector2> Performed;

        private InputScheme.UserActions inputScheme;

        public UserMovementInput(InputScheme inputScheme)
        {
            this.inputScheme = inputScheme.User;
            this.inputScheme.Movement.performed += ctx 
                => Performed?.Invoke(ctx.ReadValue<Vector2>());
        }

        public void Enable()
        {
            OnEnable?.Invoke();
            inputScheme.Movement.Enable();
        }

        public void Disable()
        {
            OnDisable?.Invoke();
            inputScheme.Movement.Disable();
        }
    }
}
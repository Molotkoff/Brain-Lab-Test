using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Molotkoff.Core;
using Zenject;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class MoveCommandObserver : IEnable, IDisable
    {
        public event Action OnEnable;
        public event Action OnDisable;

        private IInput<Vector2> movementInput;

        [Inject]
        public MoveCommandObserver([Inject(Id = InputMarker.Movement)] 
                                    IInput<Vector2> movementInput,
                                    Commands inputCommands)
        {
            this.movementInput = movementInput;
        }

        public void Enable()
        {
            //movementInput.Performed += 
        }

        public void Disable()
        {
            
        }
    }
}
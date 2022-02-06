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
    public class InputInstaller : MonoInstaller<InputInstaller>
    {
        [SerializeField]
        private Transform parentOfInstaller;

        public override void InstallBindings()
        {
            var inputScheme = new InputScheme();
            inputScheme.Enable();

            Container.Bind<InputScheme>()
                     .ToSelf()
                     .FromInstance(inputScheme)
                     .AsSingle();

            Container.Bind<IInput<Vector2>>()
                     .WithId(InputMarker.Movement)
                     .To<UserMovementInput>()
                     .AsSingle();

            Container.Bind<IInput<Vector2>>()
                     .WithId(InputMarker.Shoot)
                     .To<UserShootInput>()
                     .AsSingle();
        }
    }
}
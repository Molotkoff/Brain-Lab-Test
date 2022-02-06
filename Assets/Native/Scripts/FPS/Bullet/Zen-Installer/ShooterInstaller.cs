using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;
using UniRx;

namespace Molotkoff.FPS
{
    public class ShooterInstaller : MonoInstaller<ShooterInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ReactiveCommand<ShootCommand>>()
                     .ToSelf()
                     .AsSingle();
        }
    }
}
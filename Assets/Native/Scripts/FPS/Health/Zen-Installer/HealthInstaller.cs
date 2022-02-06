using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class HealthInstaller : MonoInstaller<HealthInstaller>
    {
        [SerializeField]
        private int health, maxHealth;

        public override void InstallBindings()
        {
            Container.Bind<IHealthModel>()
                     .To<HealthModel>()
                     .FromInstance(new HealthModel(health, maxHealth))
                     .AsSingle();

            Container.Bind<IHealthView>()
                     .To<NoHealthView>()
                     .AsSingle();
        }
    }
}
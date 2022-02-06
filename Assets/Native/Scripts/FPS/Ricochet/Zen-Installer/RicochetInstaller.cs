using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class RicochetInstaller : MonoInstaller<RicochetInstaller>
    {
        [SerializeField]
        private int ricochetsCount;

        public override void InstallBindings()
        {
            Container.Bind<IRicochetModel>()
                     .To<RicochetModel>()
                     .FromInstance(new RicochetModel(ricochetsCount))
                     .AsSingle();

            Container.Bind<IRicochetView>()
                     .To<ProxyRicochetView>()
                     .AsSingle();
        }
    }
}
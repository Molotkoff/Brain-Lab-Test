using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class BulletInstaller : MonoInstaller<BulletInstaller>
    {
        [SerializeField]
        private Transform bulletParent;
        [SerializeField]
        private BulletView bulletPrefab;

        public override void InstallBindings()
        {
            Container.Bind<IBulletViewFactory>()
                     .To<BulletViewFactory>()
                     .FromInstance(new BulletViewFactory(bulletParent, bulletPrefab))
                     .AsSingle();

            Container.Bind<IBulletFactory>()
                     .To<PoolBulletFactory>()
                     .AsSingle();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Molotkoff.Core;
using Zenject;

namespace Molotkoff.FPS
{
    public class PoolBulletFactory : IBulletFactory
    {
        private Pool<IBulletPresenter> bulletPool;

        [Inject]
        public PoolBulletFactory(IBulletViewFactory viewFactory)
        {
            this.bulletPool = new Pool<IBulletPresenter>(() => 
            {
                var viewSetup = viewFactory.Create();
                var presenter = new BulletPresenter(new BulletModel(), viewSetup);

                return presenter;
            });
        }

        public IBulletPresenter Create(Vector2 position, Vector2 direction, float speed, int maxRicochet = 0)
        {
            var bullet = bulletPool.Item;

            bullet.Model.Position = position;
            bullet.Model.Rotation = Quaternion.Euler(direction.x, 0, direction.y);
            bullet.Model.Speed = speed;

            return bullet;
        }
    }
}

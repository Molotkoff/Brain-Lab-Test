using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class BulletViewFactory : IBulletViewFactory
    {
        private Transform bulletParent;
        private BulletView bulletViewPrefab;

        public BulletViewFactory(Transform bulletParent, BulletView bulletViewPrefab)
        {
            this.bulletParent = bulletParent;
            this.bulletViewPrefab = bulletViewPrefab;
        }

        public IBulletViewSetup Create()
        {
            var view = UnityEngine.Object.Instantiate(bulletViewPrefab, bulletParent);
            view.gameObject.SetActive(false);

            return new BulletViewSetup(view);
        }
    }
}
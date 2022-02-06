using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UniRx;
using Zenject;

namespace Molotkoff.FPS
{
    public class ShooterPresenter : MonoBehaviour
    {
        [SerializeField]
        private Transform from;
        [SerializeField]
        private float bulletSpeed;
        [SerializeField]
        private int bulletRicochets;

        private IBulletFactory bulletFactory;
        private ReactiveCommand<ShootCommand> shootCommand;

        [Inject]
        public void Construct(IBulletFactory bulletFactory, 
                              ReactiveCommand<ShootCommand> shootCommand)
        {
            this.bulletFactory = bulletFactory;
            this.shootCommand = shootCommand;
        }

        public void Shoot()
        {
            var shootFrom = from.transform.forward;
            var shootDirection = GetFromShoot();

            var bullet = bulletFactory.Create(shootFrom, 
                                              shootDirection, 
                                              bulletSpeed, 
                                              bulletRicochets);
            bullet.Enable();

            var shoot = new ShootCommand(bullet);
            shootCommand.Execute(shoot);
        }

        private Vector2 GetFromShoot()
        {
            var position = transform.position;

            return new Vector2(position.x, position.z);
        }
    }
}
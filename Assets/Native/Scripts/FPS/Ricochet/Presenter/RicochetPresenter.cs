using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Zenject;

namespace Molotkoff.FPS
{
    public class RicochetPresenter : MonoBehaviour, IRicochetPresenter
    {
        public event Action<ContactPoint, Vector3> OnRicochet;

        [SerializeField]
        private Rigidbody _rigibdoby;
        [SerializeField]
        private LayerMask ricochetLayer;

        public IRicochetModel Model { get; private set; }
        public IRicochetView View { get; private set; }

        private int currentRicochets;

        private IDisposable shootDisposable, collisionDisposable;

        private ReactiveCommand<ShootCommand> shootCommand;

        [Inject]
        public void Construct(ReactiveCommand<ShootCommand> shootCommand, 
                              IRicochetModel model, 
                              IRicochetView view)
        {
            this.shootCommand = shootCommand;
            this.Model = model;
            this.View = view;
        }

        private void Awake()
        {
            shootDisposable = shootCommand.Subscribe(shoot => 
            {
                currentRicochets = 0;
            });

            collisionDisposable = this.OnCollisionEnterAsObservable().Subscribe(collision => 
            {
                if (currentRicochets > 0)
                {
                    if (collision.gameObject.layer == ricochetLayer)
                    {
                        /*
                        var velocity = _rigibdoby.velocity;
                        var ricochet = UtilRicochet.RicochetAngular<IRicochetPresenter>();
                        _rigibdoby.velocity = ricochet;
                        currentRicochets--;*/
                    }

                    if (collision.gameObject.TryGetComponent<NoHealthView>(out var health))
                    {

                    }

                    return;
                }
            });
        }

        private void OnDestroy()
        {
            shootDisposable.Dispose();
            collisionDisposable.Dispose();
        }
    }
}
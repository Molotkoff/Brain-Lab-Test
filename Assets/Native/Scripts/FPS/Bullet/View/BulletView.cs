using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class BulletView : MonoBehaviour, IBulletView
    {
        public event Action OnEnable;
        public event Action OnDisable;

        [SerializeField]
        private Rigidbody _rigidbody;

        private IBulletPresenter presenter;

        public void Setup(IBulletPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void Enable()
        {
            var direction = presenter.Model.Rotation;
            var position = presenter.Model.Position;
            var bulletForce = direction.eulerAngles * presenter.Model.Speed;

            transform.position = position;
            transform.rotation = direction;

            _rigidbody.AddForce(bulletForce);

            gameObject.SetActive(true);
            OnEnable?.Invoke();
        }

        public void Disable()
        {
            OnDisable?.Invoke();
            gameObject.SetActive(false);
        }

        public void Dispose() => Destroy(gameObject);
    }
}
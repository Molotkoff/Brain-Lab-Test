using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public class BulletPresenter : IBulletPresenter
    {
        public event Action OnEnable;
        public event Action OnDisable;

        public IBulletModel Model { get; }

        private IBulletView view;

        public BulletPresenter(IBulletModel model, IBulletViewSetup viewSetup)
        {
            this.Model = model;
            this.view = viewSetup.Setup(this);
        }

        public void Enable()
        {
            view.Enable();
            OnEnable?.Invoke();
        }

        public void Disable()
        {
            view.Disable();
            OnDisable?.Invoke();
        }

        public void Dispose() => view.Dispose();
    }
}
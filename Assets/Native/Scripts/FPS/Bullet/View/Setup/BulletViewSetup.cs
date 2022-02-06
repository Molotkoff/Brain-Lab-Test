using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public class BulletViewSetup : IBulletViewSetup
    {
        private BulletView view;

        public BulletViewSetup(BulletView view)
        {
            this.view = view;
        }

        public IBulletView Setup(IBulletPresenter presenter)
        {
            view.Setup(presenter);

            return view;
        }
    }
}
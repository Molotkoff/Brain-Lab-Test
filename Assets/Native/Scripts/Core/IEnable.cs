using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public interface IEnable
    {
        event Action OnEnable;

        void Enable();
    }
}
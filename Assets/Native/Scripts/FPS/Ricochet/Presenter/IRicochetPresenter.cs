using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public interface IRicochetPresenter
    {
        public event Action<ContactPoint, Vector3> OnRicochet;

        IRicochetModel Model { get; }
        IRicochetView View { get; }
    }
}
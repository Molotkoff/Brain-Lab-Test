using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public interface IBulletModel : IPositioneable, IRotateable
    {
        public float Speed { get; set; }
    }
}
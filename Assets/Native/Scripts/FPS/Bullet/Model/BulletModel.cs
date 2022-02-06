using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class BulletModel : IBulletModel
    {
        public Vector2 Position { get; set; }
        public Quaternion Rotation { get; set; }
        public float Speed { get; set; }
    }
}
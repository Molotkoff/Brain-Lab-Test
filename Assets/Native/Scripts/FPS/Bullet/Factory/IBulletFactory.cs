using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public interface IBulletFactory
    {
        IBulletPresenter Create(Vector2 position, Vector2 direction, float speed, int maxRicochet = 0);
    }
}
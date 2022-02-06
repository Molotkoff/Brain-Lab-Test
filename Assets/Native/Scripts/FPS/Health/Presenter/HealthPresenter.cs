using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Molotkoff.FPS
{
    public class HealthPresenter : MonoBehaviour, IHealthPresenter
    {
        public IHealthModel Model { get; private set; }
        public IHealthView View { get; private set; }

        [Inject]
        public void Construct(IHealthModel model, IHealthView view)
        {
            this.Model = model;
            this.View = view;
        }
    }
}
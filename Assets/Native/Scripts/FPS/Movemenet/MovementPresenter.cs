using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using UniRx;

namespace Molotkoff.FPS
{
    public class MovementPresenter : MonoBehaviour, IMovementPresenter
    {
        [SerializeField]
        private Rigidbody rigidbody;
        [SerializeField]
        private float speed;

        private IInput<Vector2> input;

        [Inject]
        public void Construct([Inject(Id = InputMarker.Movement)] IInput<Vector2> input)
        {
            this.input = input;
        }

        private void OnEnable()
        {
            input.Performed += Move;
        }

        private void OnDisable()
        {
            input.Performed -= Move;
        }

        public void Move(Vector2 vector)
        {
            Debug.Log("player move");

            var direction = new Vector3(vector.x, 0 , vector.y);
            rigidbody.AddForce(direction * speed);
        }
    }
}
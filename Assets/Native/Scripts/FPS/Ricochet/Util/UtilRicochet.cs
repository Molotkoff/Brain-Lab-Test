using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Molotkoff.FPS
{
    public class UtilRicochet
    {
        private static RaycastHit[] raycasts = new RaycastHit[1];

        public static Vector3 RicochetAngular(Vector3 velocity, Collision collision)
        {
            if (collision.contactCount > 0)
            {
                var contact = collision.GetContact(0).normal;
                return Vector3.Project(velocity, contact);
            }

            return velocity;
        }

        public static bool RicochetAngular(Vector3 from, Vector3 to, LayerMask ricochetMask, int maxRicochets, out Transform result)
        {
            var ray = new Ray(from, to);

            if (Physics.RaycastNonAlloc(ray, raycasts, float.MaxValue, ricochetMask) > 0)
            {
                var hit = raycasts[0].normal;
                var direction = Vector3.Reflect(from, hit);

                if (maxRicochets > 0)
                    return RicochetAngular(hit, direction, ricochetMask, maxRicochets - 1, out result);

                result = raycasts[0].transform;
                return true;
            }

            result = null;
            return false;
        }

        public static bool RicochetAngular<T>(Vector3 from, Vector3 to, LayerMask ricochetMask, int maxRicochets, out T result) where T : class
        {
            var ray = new Ray(from, to);

            if (Physics.RaycastNonAlloc(ray, raycasts, float.MaxValue, ricochetMask) > 0)
            {
                if (raycasts[0].transform.TryGetComponent(out result))
                    return true;

                var hit = raycasts[0].normal;

                var direction = Vector3.Reflect(from, hit);

                if (maxRicochets > 0)
                    return RicochetAngular(hit, direction, ricochetMask, maxRicochets - 1, out result);
            }

            result = null;
            return false;
        }
    }
}
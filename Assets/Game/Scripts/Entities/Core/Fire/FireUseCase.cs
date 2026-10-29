using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class FireUseCase
    {
        public static Quaternion WithRandomSpread(Quaternion current,float spread)
        {
            var angle = Random.Range(-spread, spread);
            var randomSpread = Quaternion.AngleAxis(angle, Vector3.up);
            return current * randomSpread;
        }
    }
}
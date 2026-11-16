using UnityEngine;

namespace Game
{
    public static class BulletRotation
    {
        public static Quaternion WithRandomSpread(this Quaternion current,float spread)
        {
            var angle = Random.Range(-spread, spread);
            var randomSpread = Quaternion.AngleAxis(angle, Vector3.up);
            return current * randomSpread;
        }
    }
}
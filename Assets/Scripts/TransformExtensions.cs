using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TransformExtensions
{
    public static class Transform_MoveTowards
    {
        public static void MoveTowards(this Transform self, Transform target, float speed)
        {
            self.position = Vector3.MoveTowards(self.position, target.position, speed * Time.deltaTime);
        }
    }
}

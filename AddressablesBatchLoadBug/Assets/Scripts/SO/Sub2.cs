using System;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(fileName = "Sub2", menuName = "Custom SOs/Sub2")]
    public class Sub2 : Base
    {
        public int Field2 = (int)DateTime.Now.Ticks;
    }
}

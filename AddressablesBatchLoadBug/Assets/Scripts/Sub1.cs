using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Sub1", menuName = "Custom SOs/Sub1")]
public class Sub1 : Base
{
    public int Field1 = (int)DateTime.Now.Ticks;
}

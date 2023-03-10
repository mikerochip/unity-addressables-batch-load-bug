using System;
using UnityEngine;

namespace SO
{
    public abstract class Base : ScriptableObject
    {
        public string Id = Guid.NewGuid().ToString();
    }
}

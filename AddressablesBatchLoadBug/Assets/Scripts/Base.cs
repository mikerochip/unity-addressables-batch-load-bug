using System;
using UnityEngine;

public abstract class Base : ScriptableObject
{
    public string Id = Guid.NewGuid().ToString();
}

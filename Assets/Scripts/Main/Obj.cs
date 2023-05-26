using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obj : MonoBehaviour // inheritance, abstraction
{
    public float angle { get; private set; } = 45.0f; // encapsulation
    protected string shapeName = "null";

    public abstract void Anim(); // abstraction
}

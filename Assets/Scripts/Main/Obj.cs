using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obj : MonoBehaviour // INHERITANCE, ABSTRACTION
{
    public float angle { get; private set; } = 45.0f; // ENCAPSULATION
    protected string shapeName = "null";

    public abstract void Anim(); // ABSTRACTION
}

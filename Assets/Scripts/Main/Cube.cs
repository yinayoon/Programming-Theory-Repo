using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Obj // INHERITANCE
{
    public static Cube Instance { get; private set; } // ENCAPSULATION
    public Color ShapeColor = Color.red;

    private void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        Anim();
    }

    public override void Anim() // ABSTRACTION
    {
        shapeName = "Cube";
        transform.Rotate(angle * Time.deltaTime, angle * Time.deltaTime, angle * Time.deltaTime);
    }
}

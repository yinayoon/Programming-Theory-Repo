using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Obj // INHERITANCE
{
    public static Cylinder Instance { get; private set; } // ENCAPSULATION
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
        shapeName = "Cylinder";
        transform.Rotate(0, angle * Time.deltaTime, 0);
    }
}

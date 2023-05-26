using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Obj // INHERITANCE
{
    public static Sphere Instance { get; private set; } // ENCAPSULATION
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
        shapeName = "Sphere";
        transform.Rotate(angle * Time.deltaTime, 0, angle * Time.deltaTime);
    }
}

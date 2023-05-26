using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Obj // inheritance
{
    public static Sphere Instance { get; private set; }
    public Color ShapeColor = Color.red;

    private void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        Anim();
    }

    public override void Anim()
    {
        shapeName = "Sphere";
        transform.Rotate(angle * Time.deltaTime, 0, angle * Time.deltaTime);
    }
}

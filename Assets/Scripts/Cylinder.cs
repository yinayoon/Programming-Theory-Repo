using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Obj // inheritance
{
    public static Cylinder Instance { get; private set; }
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
        shapeName = "Cylinder";
        transform.Rotate(0, angle * Time.deltaTime, 0);
    }
}

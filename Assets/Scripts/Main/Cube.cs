using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Obj // inheritance
{
    public static Cube Instance { get; private set; }
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
        shapeName = "Cube";
        transform.Rotate(angle * Time.deltaTime, angle * Time.deltaTime, angle * Time.deltaTime);
    }
}

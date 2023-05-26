using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("- GUI")]
    public Text shapeText;

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
        LayerMask mask = LayerMask.GetMask("Cube") | LayerMask.GetMask("Cylinder") | LayerMask.GetMask("Sphere");

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100.0f, mask))
        {
            if (target == null)
            {
                target = hit.transform.gameObject;
            }

            if (target.transform.gameObject.layer == LayerMask.NameToLayer("Cube"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log("Shape : Cube");
                    //shapeText.text = "Shape : Cube";
                    DisplayText("Cube");
                }
            }
            else if (target.transform.gameObject.layer == LayerMask.NameToLayer("Cylinder"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log("Shape : Cylinder");
                    //shapeText.text = "Shape : Cylinder";
                    DisplayText("Cylinder", 50);
                }
            }
            else if (target.transform.gameObject.layer == LayerMask.NameToLayer("Sphere"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log("Shape : Sphere");
                    //shapeText.text = "Shape : Sphere";
                    DisplayText("Sphere", Color.blue);
                }
            }
        }
        else
        {
            if (target != null)
            {
                shapeText.fontSize = 30;
                shapeText.color = Color.white;
                target = null;
            }
        }
    }

    void DisplayText(string shape)
    {
        shapeText.text = $"Shape : {shape}";
    }

    void DisplayText(string shape, int fontSize)
    {
        shapeText.text = $"Shape : {shape}";
        shapeText.fontSize = fontSize;
    }

    void DisplayText(string shape, Color color)
    {
        shapeText.text = $"Shape : {shape}";
        shapeText.color = color;
    }
}

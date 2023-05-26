using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("- GUI")]
    public Text shapeText;
    public Text userNameText;

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Data Persistence");
        if (go == null)
        {
            userNameText.text = $"User Name : ";
        }
        else
        {
            userNameText.text = $"User Name : {DataPersistence.UserName}";
        }
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
                    DisplayText("Cube");
                }

                target.GetComponent<Renderer>().material.color = Cube.Instance.ShapeColor;
            }
            else if (target.transform.gameObject.layer == LayerMask.NameToLayer("Cylinder"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    DisplayText("Cylinder", 50);
                }

                target.GetComponent<Renderer>().material.color = Cylinder.Instance.ShapeColor;
            }
            else if (target.transform.gameObject.layer == LayerMask.NameToLayer("Sphere"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    DisplayText("Sphere", Color.blue);
                }

                target.GetComponent<Renderer>().material.color = Sphere.Instance.ShapeColor;
            }
        }
        else
        {
            if (target != null)
            {
                shapeText.fontSize = 30;
                shapeText.color = Color.white;

                target.GetComponent<Renderer>().material.color = Color.white;
                target = null;
            }
        }
    }

    void DisplayText(string shape) // POLYMORPHISM
    {
        shapeText.text = $"Shape : {shape}";
    }

    void DisplayText(string shape, int fontSize) // POLYMORPHISM
    {
        shapeText.text = $"Shape : {shape}";
        shapeText.fontSize = fontSize;
    }

    void DisplayText(string shape, Color color) // POLYMORPHISM
    {
        shapeText.text = $"Shape : {shape}";
        shapeText.color = color;
    }
}

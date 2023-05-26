using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static string UserName;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        Debug.Log(UserName);
    }
}

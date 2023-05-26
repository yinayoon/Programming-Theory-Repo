using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static string UserName;

    [SerializeField]
    private string userName;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        userName = UserName;
    }
}

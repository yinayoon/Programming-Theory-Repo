using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    [Header ("- GUI")]
    public Text inputFieldText;

    private void Update()
    {
        DataPersistence.UserName = inputFieldText.text;
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
}

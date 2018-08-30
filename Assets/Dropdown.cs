using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadSceneを使うために必要!!

public class Dropdown : MonoBehaviour
{
    public void OnValueChanged(UnityEngine.UI.Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                SceneManager.LoadScene("HomeScene");
                break;
            case 1:
                SceneManager.LoadScene("EvaluateScene");
                break;
            case 2:
                SceneManager.LoadScene("DataScene");
                break;
            default:
                break;
        }
    }
}
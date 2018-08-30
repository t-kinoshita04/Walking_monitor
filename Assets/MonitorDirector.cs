using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadSceneを使うために必要!!

public class MonitorDirector : MonoBehaviour {
    // ボタンをクリックするとEvaluateSceneに移動します
    public void ButtonClicked(int number)
    {
        switch (number)
        {
            case 0:
                SceneManager.LoadScene("EvaluateScene");
                break;
            case 1:
                SceneManager.LoadScene("DataScene");
                break;
            default:
                break;
        }
        
    }
}

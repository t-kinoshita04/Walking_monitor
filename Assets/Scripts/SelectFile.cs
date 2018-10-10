using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class SelectFile : MonoBehaviour {
	
	void Start ()
    {
           
	}

    void Update()
    {

    }

    public void ButtonClick()
    {
        private string[] files = Directory.GetFiles(".");
        
        private void dispFilesOnButtons(string filename, int idx, int shift) {
            int pos = idx - shift;
            GameObject work = GameObject.Find("Button" + pos.ToString() + "Text");
            
        }
    }
}

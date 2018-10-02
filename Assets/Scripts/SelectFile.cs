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
        string[] files = Directory.GetFiles(".");
        
        void dispFilesOnButtons(string filename, int idx, int shift) {

        }
    }
}

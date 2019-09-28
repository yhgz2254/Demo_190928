using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		// ShowText("Hello World");
        Debug.Log("Hello vsCode");
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ShowText(string txt)
	{
		GUI.Label(new Rect(10, 10, 10, 10), txt);
	}
}

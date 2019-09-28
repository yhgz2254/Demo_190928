using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBtnHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // this.GetComponet<Button>().onclick.AddListener (Onclick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick() 
    {
        Debug.Log("On me, quit");
        Application.Quit();
    }
}

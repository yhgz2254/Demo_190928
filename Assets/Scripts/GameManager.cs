using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour


{

    public float timer;

    public static GameManager instance;

    public Settings Setting;

    private void Awake() 
    {
        // Get a singleton for this Core of game
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // Init game settings as config
        Setting = new Settings();
        // Setting = gameObject.AddComponet<Setting>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

}

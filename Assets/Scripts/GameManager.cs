using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LitJson;

public class GameManager : MonoBehaviour


{

    public float timer;

    public static GameManager instance;

    public Settings Setting;
    
    private int tt = 0;
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

        tt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (tt == 0)
        {            
            TestJson obj = new TestJson();
            obj.name = "obj";
            // Debug.Log(JsonMapper.ToJson(obj));

            Debug.Log("this is from handler" + JsonHandler.ToJson(obj));
            
            tt = 1;
        }
    }

    class TestJson
    {
        public string name;
        public int level;
        public int[] probs = new int[5];
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class JsonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public string ToJson(object obj)
    {
        return JsonMapper.ToJson(obj);
    }
    
}

// Document sample
// // Serialize object to JSON
// 		var toObject = new HelloWorld{ Message = "Hello world!" };
// 		var toJson = LitJson.JsonMapper.ToJson(toObject);
// 		Console.WriteLine("To JSON: {0}", toJson);

		
// 		// Serialize JSON to object
// 		var fromJson = "{\"Message\":\"Hello world!\"}";
// 		var fromObject = LitJson.JsonMapper.ToObject<HelloWorld>(fromJson);	
// 		Console.WriteLine("From json: {0}", fromObject.Message);


    // public void JsonTest()
    // {
    //     TestJson tj = new TestJson();
    //     tj.name = "Goozst";
    //     tj.level = 13;
    //     tj.probs[0] = 1;
    //     tj.probs[1] = 132;

    //     string tjStr = JsonMapper.ToJson(tj);
    //     Debug.Log(tjStr);
    // }
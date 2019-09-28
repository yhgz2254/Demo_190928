using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
	public int a;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
		if (a < 10)
		{
			// Debug.Log(a);
			// Debug.Log(a.GetType());
		}

		a = addNum(a);
    }

	private int addNum (int n) {
		n = n + 1;
		return n;
	}
}

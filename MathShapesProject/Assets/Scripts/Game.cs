using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {


    private int coins;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 20; i++)
        {
            coins++;
            if (coins > 10)
            {
                Debug.Log(">10");
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHandler : MonoBehaviour {

    private int timeout = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeout--;
    //    if (timeout == 0)
    //        Destroy(gameObject, 5);
	}
}

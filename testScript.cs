﻿using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	  if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
        }
    }
}

﻿using UnityEngine;
using System.Collections;

public class SlowlyRotate : MonoBehaviour {
	private float rotation = 0.0f;

    void Update() {
  	    rotation += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(0, 0, rotation);
    }
}
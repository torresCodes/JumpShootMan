﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.right * speed * Time.deltaTime;
	
	}
}

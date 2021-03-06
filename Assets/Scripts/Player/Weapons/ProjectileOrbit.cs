﻿using UnityEngine;
using System.Collections;

public class ProjectileOrbit : MonoBehaviour {
	
	public float projectileSpeed;
	public float lifetime;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.zero, transform.right, Time.deltaTime*projectileSpeed);
	}
}

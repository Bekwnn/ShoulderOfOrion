﻿using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour 
{
	public float minTumble;
	public float maxTumble;
	
	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * Random.Range(minTumble, maxTumble);
	}
}
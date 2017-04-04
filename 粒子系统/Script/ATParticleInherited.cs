﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATParticleInherited : ATParticleBase {
	public float _TorquePower = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();

		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddTorque (Random.value * _TorquePower);
	}
}

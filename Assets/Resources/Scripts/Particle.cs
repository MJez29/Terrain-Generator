﻿using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 1);
	}
}

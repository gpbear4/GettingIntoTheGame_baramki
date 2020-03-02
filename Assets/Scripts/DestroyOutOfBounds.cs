﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float outOfBoundsNorth = 30.0f;
    private float outOfBoundsSouth = -10.0f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= outOfBoundsNorth)
        {
            Destroy(gameObject);
        }
        if (transform.position.z <= outOfBoundsSouth)
        {
            Destroy(gameObject);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float speed = 100f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetFlashlight : MonoBehaviour
{

    Vector3 vectOffset;
    public GameObject goFollow;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        vectOffset = transform.position - goFollow.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = goFollow.transform.position + vectOffset;
        transform.rotation = Quaternion.Slerp(transform.rotation, goFollow.transform.rotation, speed * Time.deltaTime);
    }
}

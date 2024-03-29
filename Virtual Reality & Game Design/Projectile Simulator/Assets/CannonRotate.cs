﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotate : MonoBehaviour
{
    // Start is called before the first frame update
    Transform transform;
    float initX;
    float initZ;
    float centerY;
    float posY;

    void Start()
    {
        transform = GetComponent<Transform>();
        centerY = transform.position.y;
        posY = transform.lossyScale.y / 4;
        initX = transform.position.x;
        initZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("" + (transform.position.y - transform.lossyScale.y));
        //Debug.Log("x: " + transform.position.x + "y: " + transform.position.y + "z: " + transform.position.z);
        Debug.Log("" + transform.position.y + " " + transform.lossyScale.y / 2);
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(new Vector3(initX, centerY + posY, initZ), new Vector3(1, 0, 0), 100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(new Vector3(initX, centerY + posY, initZ), new Vector3(-1, 0, 0), 100 * Time.deltaTime);
        }
    }
}

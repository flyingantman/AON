﻿using UnityEngine;
using System.Collections;

public class circlebullet : MonoBehaviour
{
    public int counter, counterMax;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == counterMax)
        {
            Destroy(this.gameObject);
        }
        counter++;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "TrianglePlayer")
        {
            Destroy(this.gameObject);
        }
    }
}

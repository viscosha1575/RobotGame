﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivator : MonoBehaviour
{
    public static BossActivator instance;

    public GameObject entrance, theBoss;  //площадка и сам босс

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // показать боса, убрать мост
    {
        if (other.tag == "Player")
        {
            entrance.SetActive(false);
            theBoss.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

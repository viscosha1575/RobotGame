﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //ранение боса
    {
        if(other.tag == "Player")
        {
            BossController.instance.DamageBoss();
        }
    }
}


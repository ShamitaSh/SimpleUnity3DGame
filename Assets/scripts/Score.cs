﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreKeep;
    // Update is called once per frame
    void Update()
    {
        scoreKeep.text = player.position.z.ToString("0");
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> 
{
    void Awake()
    {
        GameManager gm = GameManager.instance;
    }
        
}
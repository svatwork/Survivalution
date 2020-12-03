using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    //public static PlayerStats instance;
    
    // STATS
    
    // health
    public static int maxHealth = 100;

    public static float healthRegenRate = 0f;

    private static int _curHealth;
    public static int curHealth
    {
        get { return _curHealth; }
        set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
    }


    // speed
    public static float movementSpeed = 5f;


    // FUNCTIONS
    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //    
    //    curHealth = maxHealth;
    //}
}

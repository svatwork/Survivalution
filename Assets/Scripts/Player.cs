using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //private PlayerStats stats;

    
    // Start is called before the first frame update
    void Start()
    {
        //stats = PlayerStats.instance;
        //statusIndicator.SetHealth(stats.curHealth, stats.maxHealth);

        InvokeRepeating("RegenHealth", 1f / PlayerStats.healthRegenRate, PlayerStats.healthRegenRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RegenHealth()
    {
        PlayerStats.curHealth += 1;
        //statusIndicator.SetHealth(stats.curHealth, stats.maxHealth';
    }
}

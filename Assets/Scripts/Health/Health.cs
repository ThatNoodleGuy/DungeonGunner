using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Health : MonoBehaviour
{
    private int startingHealth;
    private int currentHealth;

    /// <summary>
    /// Set Starting Health
    /// <summary>
    public void SetStartingHealth(int startingHealth)
    {
        this.startingHealth = startingHealth;
        currentHealth = startingHealth;
    }
    
    /// <summary>
    /// Get the starting health
    /// <summary>
    public int GetStartingHealth()
    {
        return startingHealth;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    //store the max health of this gameObject.
    [SerializeField]
    private float _maxHealth;

    //property for setting and getting the max health of this gameObject.
    public float MaxHealth
    {
        get => _maxHealth;
        set=> _maxHealth = value;
    }

    [SerializeField]
    private float _health; 

    public float Health
    {
        get
        {
            return _health;
        }
    }

    /// <summary>
    /// Subtracts the given damage value from the health
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health < 0)
            _health = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        //If the object health is lower or equal to 0, destroy the object
        if (_health <= 0)
            Destroy(gameObject);
    }
}

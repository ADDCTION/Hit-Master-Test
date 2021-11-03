using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int _Health = 3;
    public HealthBar healthBar;


    public void Awake()
    {
        healthBar.SetMaxHealth(_Health);
    }
    public void TakeDamage(int _Damage)
    {
        _Health -= _Damage;
        healthBar.SetHealth(_Health);

        if (_Health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
        Player._Kills += 1;
    }
}

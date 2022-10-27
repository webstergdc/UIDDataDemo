using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;

    private void Start()
    {
        InitVariables();
    }

    public void CheckHealth()
    {
        if (health <= 0)
            health = 0;
        if (health > maxHealth)
            health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
        CheckHealth();
    }
    public void Heal(int healthadded)
    {
        health = health + healthadded;
        CheckHealth();
    }

    public void InitVariables()
    {
        health = 5;
        maxHealth = 5;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    [SerializeField] private int mana,
                coins;

    public void load()
    {
        health = GlobalGameState.currentGame.health;
        maxHealth = GlobalGameState.currentGame.maxHealth;
        mana = GlobalGameState.currentGame.mana;
        coins = GlobalGameState.currentGame.coins;
    }

    public void save()
    {
        GlobalGameState.currentGame.health = health;
        GlobalGameState.currentGame.maxHealth = maxHealth;
        GlobalGameState.currentGame.mana = mana;
        GlobalGameState.currentGame.coins = coins;
    }
}

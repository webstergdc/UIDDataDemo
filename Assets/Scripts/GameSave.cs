using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameSave
{
    public Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    public List<InventoryItem> inventory;

    public int health,
                maxHealth,
                mana,
                coins;

    public void Init()
    {
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        inventory = new List<InventoryItem>();

        health = 5;
        maxHealth = 5;
        mana = 10;
        coins = 0;
    }

    private void readFile()
    {
        string gamesave = File.ReadAllText($"{ Application.persistentDataPath}/savefile.json", System.Text.Encoding.UTF8);
        GameSave load = JsonUtility.FromJson<GameSave>(gamesave);

        m_itemDictionary = load.m_itemDictionary;
        inventory = load.inventory;
        health = load.health;
        maxHealth = load.maxHealth;
        mana = load.mana;
        coins = load.coins;

        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().load();
        GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>().load();

    }

    private void writeFile()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().save();
        GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>().save();

        string json = JsonUtility.ToJson(this); 
        File.WriteAllText($"{ Application.persistentDataPath}/savefile.json", json);
    }
}

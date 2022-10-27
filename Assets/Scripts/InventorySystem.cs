using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    public List<InventoryItem> inventory { get; private set; }

    private void Awake()
    {
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
    }

    public void add(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem item))
            item.AddtoStack();
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData, newItem);
        }
    }

    public void remove(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem item))
        {
            item.RemoveFromStack();
            
            if(item.stackSize == 0)
            {
                inventory.Remove(item);
                m_itemDictionary.Remove(referenceData);
            }
        }
    }

    public void load()
    {
        inventory = GlobalGameState.currentGame.inventory;
        m_itemDictionary = GlobalGameState.currentGame.m_itemDictionary;
    }

    public void save()
    {
        GlobalGameState.currentGame.inventory = inventory;
        GlobalGameState.currentGame.m_itemDictionary = m_itemDictionary;
    }
}

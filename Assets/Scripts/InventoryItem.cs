using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class InventoryItem : MonoBehaviour
{
    public InventoryItemData data { get; private set; }
    public int stackSize { get; private set; }

    public InventoryItem(InventoryItemData source)
    {
        data = source;
        AddtoStack();
    }

    public void AddtoStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }

}

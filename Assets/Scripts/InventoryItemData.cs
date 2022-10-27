using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Inventory Item Data")]
public class InventoryItemData : ScriptableObject
{
    public string   id,
                    displayname;
    public Sprite   icon;
    GameObject      prefab;
}

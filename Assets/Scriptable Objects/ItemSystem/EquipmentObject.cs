using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public int atkBonus;
    public int defBonus;
    public int regenBonus;
    public int spdBonus;
    public EquipmentType eqpType;
    public void Awake()
    {
        type = ItemType.Equipment;
        eqpType = EquipmentType.Other;
    }
}

public enum EquipmentType
{
    Weapon,
    Armor,
    Accessory,
    Boots,
    Other
}
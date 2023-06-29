using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public abstract class Item : ScriptableObject
{
    public Sprite ItemSprite;
    public string ItemName;
    public Rarity ItemRarity;
    public int ItemBuyPrice;
    public int ItemSellPrice;

    public abstract void Use();

    public abstract void Remove();
}

public enum Rarity
{
    Common, Uncommon, Rare, Epic, Legendary, Mythic
}
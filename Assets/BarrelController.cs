using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : IInteractable
{
    // Barrels can be lootable
    // If the barrel is empty, the player jump on it and put himself inside
    // This action i believe will be merely decorative or visual, no gameplay affected by this

    List<Item> LootItems;

    bool IsEmpty()
    {
        return LootItems.Count == 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Focus();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Unfocus();
    }

    public override void Focus()
    {
        InteractionController.Instance.ShowInteractionMessage(this);
    }
    public override void Unfocus()
    {
        InteractionController.Instance.HideInteractionMessage(this);

    }

    public override void PrimaryUse()
    {
        //if is empty hide, if not empty loot
        print("INTERACTED WITH BARREL");
    }


}

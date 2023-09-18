using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepyCatController : IInteractable
{
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
        print("INTERACTED WITH CAT");
        GetComponentInChildren<Animator>().Play("LittleWakeUp");
    }
}

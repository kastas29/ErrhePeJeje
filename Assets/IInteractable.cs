using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IInteractable : MonoBehaviour
{
    public abstract void Focus(); // This is when the player approaches the interactable thing
    public abstract void Unfocus(); // This is when the player goes away from the interactable thing

    public abstract void PrimaryUse(); // This is the main action the interactable thing will do

}

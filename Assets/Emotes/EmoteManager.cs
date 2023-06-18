using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteManager : MonoBehaviour
{
    public List<Emote> availableEmotes = new List<Emote>(); // List of all available emotes
    public Emote[] equippedEmotes = new Emote[8]; // Array to store equipped emotes (size 4)

    // Function to equip an emote at a specific index
    public void EquipEmote(int index, Emote emote)
    {
        if (index < 0 || index >= equippedEmotes.Length)
        {
            Debug.LogError("Invalid emote index!");
            return;
        }

        equippedEmotes[index] = emote;
    }

    // Function to unequip an emote at a specific index
    public void UnequipEmote(int index)
    {
        if (index < 0 || index >= equippedEmotes.Length)
        {
            Debug.LogError("Invalid emote index!");
            return;
        }

        equippedEmotes[index] = null;
    }

    // Function to get the currently equipped emote at a specific index
    public Emote GetEquippedEmote(int index)
    {
        if (index < 0 || index >= equippedEmotes.Length)
        {
            Debug.LogError("Invalid emote index!");
            return null;
        }

        return equippedEmotes[index];
    }

    // Function to check if an emote is equipped
    public bool IsEmoteEquipped(Emote emote)
    {
        return System.Array.IndexOf(equippedEmotes, emote) != -1;
    }
}

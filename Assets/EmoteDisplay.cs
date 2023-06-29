using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EmoteDisplay : MonoBehaviour
{
    public TextMeshProUGUI EmoteName;
    public List<GameObject> ButtonChilds;

    private void Start()
    {
        print("starting emotes");

        // Subscribe to the event to see correctly the emote radial menu
        GetComponent<EmoteManager>().OnEmoteEquipped += RefreshEmoteUI;

        RefreshEmoteUI();
    }

    public void ChangeEmoteDisplayText(GameObject ButtonHovered)
    {
        switch (ButtonHovered.name)
        {
            case "Button0":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[0]?.EmoteName;
                break;
            case "Button1":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[1]?.EmoteName;
                break;
            case "Button2":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[2]?.EmoteName;
                break;
            case "Button3":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[3]?.EmoteName;
                break;
            case "Button4":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[4]?.EmoteName;
                break;
            case "Button5":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[5]?.EmoteName;
                break;
            case "Button6":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[6]?.EmoteName;
                break;
            case "Button7":
                EmoteName.text = GetComponent<EmoteManager>()?.equippedEmotes[7]?.EmoteName;
                break;
            default:
                EmoteName.text = "";
                break;
        }
    }

    public void RemoveEmoteDisplayText() { EmoteName.text = ""; }

    void RefreshEmoteUI()
    {
        for(int i = 0; i < ButtonChilds.Count; i++)
        {
            print("ButtonChilds[i] " + ButtonChilds[i].name);
            ButtonChilds[i].transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<EmoteManager>()?.equippedEmotes[i]?.EmoteSprite;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EmoteButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentInParent<EmoteDisplay>().ChangeEmoteDisplayText(this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponentInParent<EmoteDisplay>().RemoveEmoteDisplayText();
    }
}

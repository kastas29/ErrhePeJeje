using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectCharacterPrefab : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{

    public AudioClip HoverCharacterSound;
    public AudioClip SelectCharacterSound;
    public AudioClip FavouriteCharacterSound;
    public AudioClip ConfirmCharacterSound;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse has entered the GameObject.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse is no longer on GameObject.");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Selected GameObject.");
    }
}

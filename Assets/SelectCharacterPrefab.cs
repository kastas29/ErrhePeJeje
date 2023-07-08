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

    [SerializeField] GameObject CharacterSelectBorders;
    [SerializeField] GameObject FavouriteStar;
    /*
    void OnMouseDown()
    {
        Debug.Log("Selected GameObject.");
    }

    void OnMouseEnter()
    {
        CharacterSelectBorders.SetActive(true);
    }

    void OnMouseExit()
    {
        CharacterSelectBorders.SetActive(false);
    }
    */
    public void OnPointerEnter(PointerEventData eventData)
    {
        CharacterSelectBorders.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CharacterSelectBorders.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Selected GameObject.");
    }
}

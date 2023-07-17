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
        this.transform.localScale = new Vector3(2.33f, 2.33f, 2.33f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CharacterSelectBorders.SetActive(false);
        this.transform.localScale = new Vector3(2, 2, 2);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        CharacterCustomizationController.Instance.LastCharacterSelected?.transform?.GetChild(8)?.gameObject?.SetActive(false);

        CharacterCustomizationController.Instance.PlayerObject = this.gameObject;

        print("ASDF " + CharacterCustomizationController.Instance.PlayerObject.name);

        CharacterCustomizationController.Instance.PlayerObject.transform.GetChild(8).gameObject.SetActive(true);

        CharacterCustomizationController.Instance.LastCharacterSelected = CharacterCustomizationController.Instance.PlayerObject;
    }
}

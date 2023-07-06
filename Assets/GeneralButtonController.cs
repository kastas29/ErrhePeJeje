using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GeneralButtonController : MonoBehaviour, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{

    [SerializeField] Sprite NormalButtonSprite;
    [SerializeField] Sprite HighlightedButtonSprite;
    [SerializeField] Sprite PressedButtonSprite;

    [SerializeField] Image SpriteRenderer;

    public void OnPointerDown(PointerEventData eventData)
    {
        SpriteRenderer.sprite = PressedButtonSprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        SpriteRenderer.sprite = HighlightedButtonSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        SpriteRenderer.sprite = NormalButtonSprite;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SpriteRenderer.sprite = NormalButtonSprite;
    }
}

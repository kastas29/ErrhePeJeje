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

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SpriteRenderer.sprite = PressedButtonSprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        SpriteRenderer.sprite = HighlightedButtonSprite;
        anim.Play("GeneralButtonPointerOver");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        SpriteRenderer.sprite = NormalButtonSprite;
        anim.Play("GeneralButtonPointerExit");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SpriteRenderer.sprite = NormalButtonSprite;
    }
}

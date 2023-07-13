using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopCategoriesBTNController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject LabelToOpen;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LabelToOpen.GetComponent<Animator>().Play("Appear");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("Exit label hover??");
        LabelToOpen.GetComponent<Animator>().Play("Disappear");
    }
}

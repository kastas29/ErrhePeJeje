using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceController : IInteractable
{
    public override void Focus()
    {
        InteractionController.Instance.ShowInteractionMessage(this);
    }

    public override void PrimaryUse()
    {
        GameManager.Instance.ChangeScene("CoffeShop");
    }

    public override void Unfocus()
    {
        InteractionController.Instance.HideInteractionMessage(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Focus();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Unfocus();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

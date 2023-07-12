using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemsController : MonoBehaviour
{
    static ShopItemsController Instance;

    public List<ShopItemsSO> CosmeticItemsList;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ListItems()
    {

    }

    public void UnlockItem(ShopItemsSO item)
    {

    }
}

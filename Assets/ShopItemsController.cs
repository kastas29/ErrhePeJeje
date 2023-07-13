using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemsController : MonoBehaviour
{
    static ShopItemsController Instance;

    public List<ShopItemsSO> HeadShopItemsList;
    public List<ShopItemsSO> FaceShopItemsList;
    public List<ShopItemsSO> EyesShopItemsList;
    public List<ShopItemsSO> BodyShopItemsList;
    public List<ShopItemsSO> PantsShopItemsList;

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

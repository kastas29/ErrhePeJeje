using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanelController : MonoBehaviour
{
    [SerializeField] GameObject ShopItemPrefab;

    [SerializeField] GameObject ShopItemsPanel;

    [Header("Items Lists")]
    public List<ShopItemsSO> HeadShopItemsList;
    public List<ShopItemsSO> FaceShopItemsList;
    public List<ShopItemsSO> EyesShopItemsList;
    public List<ShopItemsSO> BodyShopItemsList;
    public List<ShopItemsSO> PantsShopItemsList;

    public enum Category { HEAD, FACE, EYES, BODY, PANTS }

    private void OnEnable()
    {
        GetComponent<Animator>().Play("OpenShopPanel");
    }

    public void ListItemsByCategory(int CategoryToOpen)
    {
        // Remove alll childs
        foreach (Transform go in ShopItemsPanel.transform)
        {
            Destroy(go.gameObject);
        }

        List<ShopItemsSO> tempList = new List<ShopItemsSO>();
        switch (CategoryToOpen)
        {
            case 1:
                tempList = HeadShopItemsList;
                break;
            case 2:
                tempList = FaceShopItemsList;
                break;
            case 3:
                tempList = EyesShopItemsList;
                break;
            case 4:
                tempList = BodyShopItemsList;
                break;
            case 5:
                tempList = PantsShopItemsList;
                break;
        }

        foreach (ShopItemsSO item in tempList)
        {
            GameObject newItem = Instantiate(ShopItemPrefab, ShopItemsPanel.transform);

            newItem.gameObject.transform.GetChild(2).GetComponent<Image>().sprite = item.ItemIcon;

            // Check if the item is already unlocked, and hide or remove the 'lock' stuff
            if (item.IsUnlocked)
            {
                newItem.gameObject.transform.GetChild(3).gameObject.SetActive(false);
                newItem.gameObject.transform.GetChild(4).gameObject.SetActive(false);
            }

        }
    }

    public void CloseShopPanel()
    {
        GetComponent<Animator>().Play("CloseShopPanel");
        StartCoroutine(DisableShopPanelObject());
    }
    private IEnumerator DisableShopPanelObject()
    {
        yield return new WaitForSeconds(0.2f);
        this.gameObject.SetActive(false);
    }
}

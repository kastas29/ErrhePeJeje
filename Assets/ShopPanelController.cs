using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanelController : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Animator>().Play("OpenShopPanel");
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

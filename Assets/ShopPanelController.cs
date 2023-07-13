using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanelController : MonoBehaviour
{
    [SerializeField] GameObject Cat_HeadPanel;
    [SerializeField] GameObject Cat_FacePanel;
    [SerializeField] GameObject Cat_EyesPanel;
    [SerializeField] GameObject Cat_BodyPanel;
    [SerializeField] GameObject Cat_PantsPanel;



    private void OnEnable()
    {
        GetComponent<Animator>().Play("OpenShopPanel");
    }

    public void OpenHeadCategoryPanel()
    {
        Cat_HeadPanel.SetActive(true);
        Cat_FacePanel.SetActive(false);
        Cat_EyesPanel.SetActive(false);
        Cat_BodyPanel.SetActive(false);
        Cat_PantsPanel.SetActive(false);
    }

    public void OpenFaceCategoryPanel()
    {
        Cat_HeadPanel.SetActive(false);
        Cat_FacePanel.SetActive(true);
        Cat_EyesPanel.SetActive(false);
        Cat_BodyPanel.SetActive(false);
        Cat_PantsPanel.SetActive(false);
    }

    public void OpenEyesCategoryPanel()
    {
        Cat_HeadPanel.SetActive(false);
        Cat_FacePanel.SetActive(false);
        Cat_EyesPanel.SetActive(true);
        Cat_BodyPanel.SetActive(false);
        Cat_PantsPanel.SetActive(false);
    }

    public void OpenBodyCategoryPanel()
    {
        Cat_HeadPanel.SetActive(false);
        Cat_FacePanel.SetActive(false);
        Cat_EyesPanel.SetActive(false);
        Cat_BodyPanel.SetActive(true);
        Cat_PantsPanel.SetActive(false);
    }

    public void OpenPantsCategoryPanel()
    {
        Cat_HeadPanel.SetActive(false);
        Cat_FacePanel.SetActive(false);
        Cat_EyesPanel.SetActive(false);
        Cat_BodyPanel.SetActive(false);
        Cat_PantsPanel.SetActive(true);
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

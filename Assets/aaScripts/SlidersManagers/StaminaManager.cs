using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class StaminaManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public GameObject sliderGameObject;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.stamina_max;
        StartCoroutine(FillStamina());
        onSliderCharged();
    }

    IEnumerator FillStamina()
    {
        sliderGameObject.SetActive(true);
        while (characterStats.current_stamina < characterStats.stamina_max)
        {
            yield return new WaitForSeconds(characterStats.stamina_regenVelocity);


            setStamina(1);

        }
        sliderGameObject.SetActive(false);
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.current_stamina;
        if (characterStats.current_stamina == characterStats.stamina_max)
        {
            sliderGameObject.SetActive(false);
        }
        slider.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = characterStats.current_stamina.ToString();
    }

    public void setStamina(int value)
    {
        if (value > 0)
        {
            characterStats.current_stamina += value;
            if (characterStats.current_stamina > characterStats.stamina_max)
            {
                characterStats.current_stamina = characterStats.stamina_max;
            }

        }
        else
        {
            if (characterStats.current_stamina == characterStats.stamina_max)
            {
                characterStats.current_stamina += value;
                StartCoroutine(FillStamina());
            }
            else
            {
                characterStats.current_stamina += value;
            }
        }
        onSliderCharged();
    }

    public void setMaxStamina(int value)
    {
        characterStats.stamina_max += value;
        slider.maxValue = characterStats.stamina_max;
    }
}

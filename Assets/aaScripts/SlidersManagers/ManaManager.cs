using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.mana_max;
        StartCoroutine(FillMana());
        onSliderCharged();
    }

    IEnumerator FillMana()
    {
        while (characterStats.current_mana < characterStats.mana_max)
        {
            yield return new WaitForSeconds(characterStats.mana_regenVelocity);
            if (characterStats.mana_max > 0)
            {
                if (characterStats.current_mana < characterStats.mana_max)
                {
                    setMana(1);
                }
            }
        }
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.current_mana;
    }


    public void setMana(int value)
    {
        if (value > 0)
        {
            characterStats.current_mana += value;
            if (characterStats.current_mana > characterStats.mana_max)
            {
                characterStats.current_mana = characterStats.mana_max;
            }

        }
        else
        {
            if (characterStats.current_mana == characterStats.mana_max)
            {
                characterStats.current_mana += value;
                StartCoroutine(FillMana());
            }
            else
            {
                characterStats.current_mana += value;
            }
        }
        onSliderCharged();
    }

    // Fase beta a saber que coño pasa cuando aumentemos el mana maximo
    public void setMaxMana(int value)
    {
        characterStats.mana_max += value;
        slider.maxValue = characterStats.mana_max;
    }
}

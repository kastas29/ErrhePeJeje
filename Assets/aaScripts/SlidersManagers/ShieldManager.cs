using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.shield_max;
        StartCoroutine(FillShield());
        onSliderCharged();
    }

    IEnumerator FillShield()
    {
        while (characterStats.shield < characterStats.shield_max)
        {
            yield return new WaitForSeconds(10f);
            if (characterStats.shield_max > 0)
            {
                if (characterStats.shield < characterStats.shield_max)
                {
                    setShield(characterStats.shield_max / 10);
                }
            }
        }
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.shield;
    }


    public void setShield(int value)
    {
        if (value > 0)
        {
            characterStats.shield += value;
            if (characterStats.shield > characterStats.shield_max)
            {
                characterStats.shield = characterStats.shield_max;
            }
        }
        else
        {
            if (characterStats.shield == characterStats.shield_max)
            {
                characterStats.shield += value;
                StartCoroutine(FillShield());
            }
            else
            {
            }
        }
        onSliderCharged();
    }

    // Fase beta a saber que coño pasa cuando aumentemos la armadura maxima
    public void setMaxShield(int value)
    {
        characterStats.shield_max += value;
        slider.maxValue = characterStats.shield_max;
    }
}

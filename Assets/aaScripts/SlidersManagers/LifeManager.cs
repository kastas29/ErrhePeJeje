using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.hp_max;
        onSliderCharged();
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.current_hp;
    }


    public void setHp(int value)
    {
        characterStats.current_hp += value;
        if (characterStats.current_hp > characterStats.hp_max)
        {
            characterStats.current_hp = characterStats.hp_max;
        }
        else if (characterStats.current_hp < 0)
        {
            characterStats.current_hp = 0;
        }
        onSliderCharged();
    }
    public void setMaxHp(int value)
    {
        characterStats.hp_max += value;
        slider.maxValue = characterStats.hp_max;
    }
}

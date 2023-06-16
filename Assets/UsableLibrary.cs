using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableLibrary : MonoBehaviour
{
    public void LearnDashSkill()
    {
        DashAbility dashAbility = gameObject.AddComponent<DashAbility>();
        print("dashability desc " + dashAbility.abilityDescription);
        AbilityManager.Instance.AddAbility(dashAbility);
    }
}

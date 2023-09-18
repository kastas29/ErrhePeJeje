using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [SerializeField] List<Quest> ActiveQuestList;

    public bool HasActiveQuest()
    {
        if (ActiveQuestList.Count == 0)
        {
            return false;
        }
        else return true;
    }

    public List<Quest> ActiveQuest()
    {
        return ActiveQuestList;
    }
}

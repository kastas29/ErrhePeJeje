using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStoryMakerController : MonoBehaviour
{
    public CharacterVisualsSO CharacterPreview;

    public GameObject Preview;

    private void Start()
    {
        Instantiate(CharacterPreview.CharacterObject, Preview.transform);
    }
}

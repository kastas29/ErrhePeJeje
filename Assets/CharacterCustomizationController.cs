using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationController : MonoBehaviour
{

    public List<Sprite> FacesImages;
    public List<Sprite> HeadImages;
    public List<Sprite> BaseImages;

    public int FaceIndex = 0;
    public int HeadIndex = 0;
    public int BaseIndex = 0;

    public Image FaceImage;
    public Image HeadImage;
    public Image BaseImage;

    public void PreviousFace()
    {
        FaceIndex--;
        if (FaceIndex < 0)
        {
            FaceIndex = FacesImages.Count - 1;
        }
        FaceImage.sprite = FacesImages[FaceIndex];
    }

    public void NextFace()
    {
        FaceIndex++;
        if (FaceIndex > FacesImages.Count - 1)
        {
            FaceIndex = 0;
        }
        FaceImage.sprite = FacesImages[FaceIndex];
    }
}

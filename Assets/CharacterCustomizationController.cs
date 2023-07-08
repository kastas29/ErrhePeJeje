using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationController : MonoBehaviour
{

    public List<Sprite> BodyImages;
    public List<Sprite> PantsImages;
    public List<Sprite> EyesImages;
    public List<Sprite> HeadDecorationsImages;
    public List<Sprite> FaceDecorationsImages;

    public List<GameObject> Players;

    private void Start()
    {
        GenerateNewPlayers();

        LoadModdedCharacterCustomizationImages("./mods/Cosmetics/Head");
    }

    public static Texture2D LoadModdedCharacterCustomizationImages(string filePath)
    {

        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            List<string> AllHeadImages = new List<string>();
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(16, 16);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }

    public void GenerateNewPlayers()
    {
        print("start generate");
        foreach (GameObject Character in Players)
        {
            print("character name " + Character.name);

            // If it is favourite, do not generate
            if (Character.transform.GetChild(6).gameObject.activeInHierarchy) continue;

            Character.transform.GetChild(1).transform.GetComponent<Image>().sprite = BodyImages[Random.Range(0, BodyImages.Count - 1)];
            Character.transform.GetChild(2).transform.GetComponent<Image>().sprite = PantsImages[Random.Range(0, PantsImages.Count - 1)];
            Character.transform.GetChild(3).transform.GetComponent<Image>().sprite = EyesImages[Random.Range(0, EyesImages.Count - 1)];
            Character.transform.GetChild(4).transform.GetComponent<Image>().sprite = HeadDecorationsImages[Random.Range(0, HeadDecorationsImages.Count - 1)];
            Character.transform.GetChild(5).transform.GetComponent<Image>().sprite = FaceDecorationsImages[Random.Range(0, FaceDecorationsImages.Count - 1)];
        }
        print("end generate");
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        LoadModdedCharacterCustomizationImages("./mods/Cosmetics");
    }

    public void LoadModdedCharacterCustomizationImages(string folderName)
    {
        // Get all sub directories from the given path.
        string[] dirs = Directory.GetDirectories(folderName, "*", SearchOption.TopDirectoryOnly);

        // Using foreach because handles null. For each path, check images inside
        foreach (string dir in dirs)
        {
            // Get all '.png' files inside the 'dir' directory
            List<string> ImageNames = Directory.GetFiles(dir, "*.png", SearchOption.AllDirectories).ToList();

            // If there is any file, do the loop to read them all.
            if (ImageNames.Count != 0)
            {
                foreach (string ImagePath in ImageNames)
                {
                    Sprite sprite = LoadImageFromFile(ImagePath);

                    switch (sprite.name)
                    {
                        case "Head":
                            HeadDecorationsImages.Add(sprite);
                            break;
                        case "Body":
                            BodyImages.Add(sprite);
                            break;
                        case "Eyes":
                            EyesImages.Add(sprite);
                            break;
                        case "Face":
                            FaceDecorationsImages.Add(sprite);
                            break;
                        case "Pants":
                            PantsImages.Add(sprite);
                            break;
                        default:
                            continue; // This is because the image has not the proper name. So go next file if this is misswritten :)
                    }
                }
            }
        }
    }

    public Sprite LoadImageFromFile(string imagePath)
    {
        // Check if the file exists
        if (!File.Exists(imagePath))
        {
            Debug.LogError("File not found: " + imagePath);
            return null;
        }

        // Load the image as a byte array
        byte[] imageData = File.ReadAllBytes(imagePath);

        // Create a new texture
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(imageData);

        // Create a sprite from the texture
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);

        return sprite;
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

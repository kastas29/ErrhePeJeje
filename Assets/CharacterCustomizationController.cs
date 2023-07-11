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
        LoadModdedCharacterCustomizationImages(".\\Assets\\mods\\Cosmetics");

        GenerateNewPlayers();
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

                    print("fileName: " + ImagePath + " || Sprite name:" + sprite.name);

                    if (sprite.name.Contains("Head"))
                    {
                        HeadDecorationsImages.Add(sprite);
                    }
                    else if (sprite.name.Contains("Body"))
                    {
                        BodyImages.Add(sprite);
                    }
                    else if (sprite.name.Contains("Eyes"))
                    {
                        EyesImages.Add(sprite);
                    }
                    else if (sprite.name.Contains("Face"))
                    {
                        FaceDecorationsImages.Add(sprite);
                    }
                    else if (sprite.name.Contains("Pants"))
                    {
                        PantsImages.Add(sprite);
                    }
                }
            }
        }
    }

    public Sprite LoadImageFromFile(string imagePath)
    {
        print("path: " + imagePath);

        // Check if the file exists
        if (!File.Exists(imagePath))
        {
            Debug.LogError("File not found: " + imagePath);
            return null;
        }

        // Load the image as a byte array
        byte[] imageData = File.ReadAllBytes(imagePath);

        // Create a new texture
        Texture2D texture = new Texture2D(16, 16);
        texture.LoadImage(imageData);
        texture.filterMode = FilterMode.Point;
        Debug.Log("Texture dimensions: " + texture.width + "x" + texture.height);

        // Create a sprite from the texture
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);

        // Split the path, and get the last element. This will be the name of the sprite.
        // This is done to manage which part of the body is this sprite, such as Head_Whatever, Pants_Wahtever, etc...
        string spriteName = imagePath.Split("\\").Last();
        spriteName.Remove(spriteName.Length - 4);
        sprite.name = spriteName;
        print("SPRITEEE: " + sprite.name);

        print("Is sprite null?: " + sprite == null);

        return sprite;
    }

    public void GenerateNewPlayers()
    {
        print("start generate");
        print("how many hairs there are? " + HeadDecorationsImages.Count);
        foreach (GameObject Character in Players)
        {
            print("character name " + Character.name);

            // If it is favourite, do not generate
            if (Character.transform.GetChild(6).gameObject.activeInHierarchy) continue;

            Character.transform.GetChild(1).transform.GetComponent<Image>().sprite = BodyImages[Random.Range(0, BodyImages.Count)];
            Character.transform.GetChild(2).transform.GetComponent<Image>().sprite = PantsImages[Random.Range(0, PantsImages.Count)];
            Character.transform.GetChild(3).transform.GetComponent<Image>().sprite = EyesImages[Random.Range(0, EyesImages.Count)];
            Character.transform.GetChild(4).transform.GetComponent<Image>().sprite = HeadDecorationsImages[Random.Range(0, HeadDecorationsImages.Count)];
            Character.transform.GetChild(5).transform.GetComponent<Image>().sprite = FaceDecorationsImages[Random.Range(0, FaceDecorationsImages.Count)];
        }
        print("end generate");
    }
}

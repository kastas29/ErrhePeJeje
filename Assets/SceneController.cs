using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public Animator anim;


    public static SceneController Instance;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void ChangeScene(string SceneName)
    {
        anim.Play("GeneralSceneTranisiton");
        StartCoroutine(LoadAsyncScene(SceneName));
    }
    public void ChangeScene(int SceneID)
    {
        anim.Play("GeneralSceneTranisiton");
        StartCoroutine(LoadAsyncScene(SceneID));
    }

    IEnumerator LoadAsyncScene(string SceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneName);

        // Wait until the scene change finishes
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        anim.Play("GeneralSceneOutTranisiton");
    }
    IEnumerator LoadAsyncScene(int SceneID)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneID);

        // Wait until the scene change finishes
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        anim.Play("GeneralSceneOutTranisiton");
    }
}

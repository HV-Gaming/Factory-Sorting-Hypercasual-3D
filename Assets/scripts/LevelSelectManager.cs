using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    public string loadingSceneName = "LoadingScene";
    public string levelScenePrefix = "Level";

    public void TransitionToLevel(int levelIndex)
    {
        string levelSceneName = levelScenePrefix + levelIndex.ToString();
        SceneManager.LoadScene(loadingSceneName);
        StartCoroutine(LoadLevelSceneAsync(levelSceneName));
    }

    private IEnumerator LoadLevelSceneAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            if (operation.progress >= 0.9f)
            {
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}


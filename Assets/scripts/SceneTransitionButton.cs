using UnityEngine;

public class SceneTransitionButton : MonoBehaviour
{
    public string sceneName; // The name of the scene to transition to
    public LoadingScreenManager loadingScreenManager; // Reference to the LoadingScreenManager script

    public void TransitionToScene()
    {
        loadingScreenManager.LoadScene(sceneName);
    }
}

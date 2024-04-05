using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneToLoad;

    public void OnClickPlay()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
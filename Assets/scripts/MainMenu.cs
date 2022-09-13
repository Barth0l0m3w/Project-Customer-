using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string backSceneName;
    private string activeSceneName;
    Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        activeSceneName = scene.name;
    }

    public void GoScene()
    {
        SceneManager.LoadScene(backSceneName);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(activeSceneName);
    }
}

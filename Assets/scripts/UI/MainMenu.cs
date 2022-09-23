using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string backSceneName;

    private void Start()
    {
        
    }

    public void GoScene()
    {
        SceneManager.LoadScene(backSceneName);
    }

    public void RestartScene()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Credts()
    {
        SceneManager.LoadScene("Credits");
    }
}

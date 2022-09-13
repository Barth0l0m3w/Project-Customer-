using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string backSceneName;

    public void GoScene()
    {
        Debug.Log("going back");
        SceneManager.LoadScene(backSceneName);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpReactor : MonoBehaviour
{
    public GameObject FailedUI;
    public GameObject CompleteUI;

    public bool failed = false;
    public bool completed = false;

    public string backSceneName;

    private void Start()
    {
        FailedUI.SetActive(false);
        CompleteUI.SetActive(false);
    }

    public void GameOver()
    {
        FailedUI.SetActive(true);
        failed = true;
    }

    public void Complete()
    {
        CompleteUI.SetActive(true);
        completed = true;
    }

    public void GoScene()
    {
        SceneManager.LoadScene(backSceneName);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

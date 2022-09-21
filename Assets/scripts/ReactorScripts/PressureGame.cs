using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressureGame : MonoBehaviour
{
    public GameObject FailedUI;
    public GameObject CompleteUI;
    public GameObject AnswersUI;

    public string backSceneName;

    public bool failed;
    public bool won;

    private void Start()
    {
        FailedUI.SetActive(false);
        CompleteUI.SetActive(false);
    }
    public void WrongAnswer()
    {
        if (GameManager.Instance.InUIMode) return;

        failed = true;
        FailedUI.SetActive(true);
        AnswersUI.SetActive(false);
    }

    public void GoodAnswer()
    {
        if (GameManager.Instance.InUIMode) return;

        won = true;
        CompleteUI.SetActive(true);
        AnswersUI.SetActive(false);
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

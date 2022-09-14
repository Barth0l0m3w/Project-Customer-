using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpPipes : MonoBehaviour
{
    public float timer;

    public GameObject FailedUI;
    public GameObject CompleteUI;

    public bool failed = false;
    public bool completed = false;

    public string backSceneName;

    private void Start()
    {
        FailedUI.SetActive(false);
        CompleteUI.SetActive(false);
        failed = false;
        completed = false;
    }

    private void Update()
    {
        Timer();
    }

    private void Timer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            TimeOver();
        }
    }

    private void TimeOver()
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

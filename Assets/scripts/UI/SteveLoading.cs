using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveLoading : MonoBehaviour
{
    public static int timesLoaded;
    public GameObject beginSteve;
    public GameObject beginSteve2;

    void Start()
    {
        timesLoaded++;
    }

    void Update()
    {
        LoadSteve();
    }

    private void LoadSteve()
    {
        Time.timeScale = 0f;

        if (timesLoaded == 1)
        {
            GameManager.Instance.InUIMode = true;
            beginSteve.SetActive(true);
        }

        if (timesLoaded == 2)
        {
            if (beginSteve2 != null)
            {
                GameManager.Instance.InUIMode = true;
                beginSteve2.SetActive(true);
            }
            else {Time.timeScale = 1; }
        }
    }

    public void ExitInformation()
    {
        GameManager.Instance.InUIMode = false;

        if (beginSteve == isActiveAndEnabled)
        {
            beginSteve.SetActive(false);
            timesLoaded++;
        }
        if (beginSteve2 == isActiveAndEnabled)
        {
            beginSteve2.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
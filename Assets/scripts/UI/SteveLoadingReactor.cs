using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveLoadingReactor : MonoBehaviour
{
    public static int timesLoaded;
    public GameObject beginSteve;
    public GameObject beginSteve2;

    void Start()
    {
        LoadSteve();
        timesLoaded ++;
    }

    void Update()
    {
        Debug.Log(timesLoaded);
        LoadSteve();
    }

    private void LoadSteve()
    {
        Time.timeScale = 0f;
        if (timesLoaded <= 1)
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
        }
    }

    public void ExitInformation()
    {
        Time.timeScale = 1f;
        GameManager.Instance.InUIMode = false;

        if (beginSteve == isActiveAndEnabled)
        {
            beginSteve.SetActive(false);
            timesLoaded++;
        }
        if (beginSteve2 == isActiveAndEnabled)
        {
            beginSteve2.SetActive(false);
        }
    }
}
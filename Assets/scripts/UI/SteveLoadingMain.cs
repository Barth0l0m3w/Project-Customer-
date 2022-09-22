using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveLoadingMain : MonoBehaviour
{
    public static int timesLoaded;
    public GameObject beginSteve;
    public GameObject beginSteve2;

    void Start()
    {
        LoadSteve();
        timesLoaded++;
    }
    private void Update()
    {
        LoadSteve();
    }

    private void LoadSteve()
    {
        if (timesLoaded == 1)
        {
            beginSteve.SetActive(true);
            GameManager.Instance.InUIMode = true;
        }

        if (timesLoaded == 2)
        {
            if (beginSteve2 != null)
            {
                beginSteve2.SetActive(true);
                GameManager.Instance.InUIMode = true;
            }
        }
    }

    public void ExitInformation()
    {
        GameManager.Instance.InUIMode = false;
        //LoadSteve();

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
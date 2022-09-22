using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveLoadingGames : MonoBehaviour
{
    public GameObject beginSteve;

    void Start()
    {
        LoadSteve();
    }

    private void LoadSteve()
    {
        Time.timeScale = 0f;
        GameManager.Instance.InUIMode = true;
        beginSteve.SetActive(true);
    }

    public void ExitInformation()
    {
        Time.timeScale = 1f;
        GameManager.Instance.InUIMode = false;
        beginSteve.SetActive(false);
    }
}

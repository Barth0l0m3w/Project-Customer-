using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveLoading : MonoBehaviour
{
    public static int timesLoaded;
    public GameObject beginSteve;

    // Start is called before the first frame update
    void Start()
    {
        timesLoaded++;
        LoadSteve();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LoadSteve()
    {
        if (timesLoaded <= 1)
        {
            beginSteve.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ExitInformation()
    {
        beginSteve.SetActive(false);
        Time.timeScale = 1f;
    }
}

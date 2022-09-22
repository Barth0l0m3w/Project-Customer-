using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtons : MonoBehaviour
{
    public GameObject backButtonPrefab;
    public int selectedNumber;


    // Update is called once per frame
    void Update()
    {
        if(OrderMaker.task == selectedNumber)
        {
            backButtonPrefab.SetActive(true);
        }
        else
        {
            backButtonPrefab.SetActive(false);
        }
    }
}

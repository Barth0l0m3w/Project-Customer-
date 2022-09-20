using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReactorRefulWin : MonoBehaviour
{
    public PopUpReactor popUpReactor;

    [SerializeField]
    private int UraniumHitReactor = 0;
    public bool gameWon;


    [SerializeField] TMP_Text refulingMission;

    private void Update()
    {
        if (UraniumHitReactor == 5)
        {
            gameWon = true;
            refulingMission.color = Color.green;
            popUpReactor.Complete();
        }
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Balls"))
        {
            UraniumHitReactor += 1;
        }
    }
}

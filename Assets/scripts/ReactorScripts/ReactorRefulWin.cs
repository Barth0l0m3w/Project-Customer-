using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorRefulWin : MonoBehaviour
{
    public PopUpReactor popUpReactor;

    [SerializeField]
    private int UraniumHitReactor = 0;
    public bool gameWon;

    private void Update()
    {
        if (UraniumHitReactor == 5)
        {
            gameWon = true;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UraniumBalls : MonoBehaviour
{
    public bool UraniumHitsGround = false;
    public PopUpReactor popUpReactor;

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Balls"))
        {
            Debug.Log("balls hit ground");
            UraniumHitsGround = true;
        }

        if (UraniumHitsGround == true)
        {

            popUpReactor.GameOver();
        }
    }
}

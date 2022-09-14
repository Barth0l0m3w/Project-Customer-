using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorRefulWin : MonoBehaviour
{
    [SerializeField]
    private int UraniumHitReactor = 0;



    private void FixedUpdate()
    {
        if (UraniumHitReactor == 5)
        {
            Debug.Log("YourMother");

        }
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {


        if (collision.gameObject.CompareTag("UraniumBall"))
        {
            UraniumHitReactor += 1;
            Debug.Log("Yes daddy");

        }
       
    }
}

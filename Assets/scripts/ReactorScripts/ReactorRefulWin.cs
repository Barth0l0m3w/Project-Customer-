using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorRefulWin : MonoBehaviour
{
    [SerializeField]
    private int UraniumHitReactor = 0;
    public bool gameWon;

    private void Update()
    {
        if (UraniumHitReactor == 5)
        {
            gameWon = true;
        }
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("UraniumBall"))
        {
            UraniumHitReactor += 1;
        }
    }
}

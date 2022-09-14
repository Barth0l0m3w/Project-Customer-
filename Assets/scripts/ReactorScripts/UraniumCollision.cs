using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UraniumCollision : MonoBehaviour
{
    public float timer = 3f;

    //public bool RefulSuccsessful = false;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Reactor"))
        {
            Destroy(gameObject);
        }
    }
}



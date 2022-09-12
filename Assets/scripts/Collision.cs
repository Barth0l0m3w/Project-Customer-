using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //if(other.CompareTag("Fuel"))
        // {
        other.GetComponent<GrapperMovement>().SetFuel();
        // }
        Destroy(gameObject);
    }
}

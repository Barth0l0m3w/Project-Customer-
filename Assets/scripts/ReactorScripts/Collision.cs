using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        other.GetComponent<GrapperMovement>().SetFuel();
        ScoreManager.instance.IncreaseScore(1);

        Destroy(this.gameObject);
    }
}

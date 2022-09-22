using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    [SerializeField] TMP_Text collectFuel;

    private void OnTriggerEnter(Collider other) 
    {
        other.GetComponent<GrapperMovement>().SetFuel();
        ScoreManager.instance.IncreaseScore(1);
        FindObjectOfType<AudioManager>().Play("UraniumPickup");
        collectFuel.color = Color.green;
        Destroy(this.gameObject);
    }
}

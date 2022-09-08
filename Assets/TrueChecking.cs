using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrueChecking : MonoBehaviour
{
    public Pipes[] pipes;

    void Update()
    {
        
    }

    public void CheckState()
    {
        if (GetComponentsInChildren<Pipes>().All(p => p.isCorrectlyTurned))
        {
            Debug.Log("you've won brug");
        }
    } 
}
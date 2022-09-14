using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueChecking : MonoBehaviour
{
    private Pipes[] pipes;

    public PopUpPipes popUpPipes;

    public void CheckState()
    {
        if (GetComponentsInChildren<Pipes>().All(p => p.isCorrectlyTurned))
        {
            popUpPipes.Complete();
            Debug.Log("game complete");
        }
    }
}
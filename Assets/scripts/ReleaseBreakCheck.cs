using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReleaseBreakCheck : MonoBehaviour
{
    private ReleaseBreak[] levers;

    //public PopupTurbine popupTurbine;

    public void CheckState()
    {
        if (GetComponentsInChildren<ReleaseBreak>().All(p => p.isCorrectlyTurned))
        {
            //levers.Complete();
            Debug.Log("game complete");
        }
    }
}

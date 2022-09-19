using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseBreak : MonoBehaviour
{
    public GameObject lever;
    public Transform GameObject;
    public ReleaseBreakCheck check;

    private int timesClicked = 0;

    public bool isCorrectlyTurned;

    private float changeAngle = 90.0f;

    void Start()
    {
        check = GetComponentInParent<ReleaseBreakCheck>();
    }

    void Update()
    {
        IsCorrect();
    }


    private void OnMouseDown()
    {
        lever.transform.Rotate(Vector3.left, changeAngle);
        timesClicked ++;
    }

    private void IsCorrect()
    {
        if (timesClicked % 2 == 0)
        {
            isCorrectlyTurned = false;
        }
        else
        {
            isCorrectlyTurned = true;
            check.CheckState();
        }
    }
}

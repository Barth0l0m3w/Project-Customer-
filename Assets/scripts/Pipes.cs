using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public GameObject Pipe;
    public Transform GameObject;
    public TrueChecking check;
    public float rotation;

    public bool isCorrectlyTurned = false;
    public float pipeAngle;
    private float changeAngle = 90.0f;


    void Start()
    {
        check = GetComponentInParent<TrueChecking>();
    }

    void Update()
    {
        GetAngle();
        IsCorrect();
    }

    private void GetAngle()
    {
        rotation = GameObject.eulerAngles.z;
    }

    private void OnMouseDown()
    {
        Pipe.transform.Rotate(Vector3.forward, changeAngle);
    }

    private void IsCorrect()
    {
        if (rotation == pipeAngle)
        {
            isCorrectlyTurned = true;
            check.CheckState();
        }
        else
        {
            isCorrectlyTurned = false;
        }
    }
}

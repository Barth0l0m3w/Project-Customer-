using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public GameObject Pipe;
    public Transform GameObject;
    public TrueChecking check;

    private float rotation;

    public bool isCorrectlyTurned = false;

    public float pipeAngle1;
    public float pipeAngle2;

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
        rotation = GameObject.eulerAngles.y;
    }

    private void OnMouseDown()
    {
        if (GameManager.Instance.InUIMode) return;

        Pipe.transform.Rotate(Vector3.up, changeAngle);

        FindObjectOfType<AudioManager>().Play("PipeTurn");
    }

    private void IsCorrect()
    {
        if (rotation == pipeAngle1)
        {
            isCorrectlyTurned = true;
            check.CheckState();
        }
        else if(rotation == pipeAngle2)
        {
            isCorrectlyTurned = true;
        }
        else
        {
            isCorrectlyTurned = false;
        }
    }
}

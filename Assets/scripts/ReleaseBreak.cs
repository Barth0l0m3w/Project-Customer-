using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseBreak : MonoBehaviour
{
    public GameObject lever;
    public Transform GameObject;
    public ReleaseBreakCheck check;

    [SerializeField] private float rotation;
    public float leverAngle1;
    public float leverAngle2;

    public bool isCorrectlyTurned = false;

    private float changeAngle = 90.0f;

    void Start()
    {
        check = GetComponentInParent<ReleaseBreakCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        GetAngle();
        IsCorrect();
    }
    
    private void GetAngle()
    {
        rotation = GameObject.eulerAngles.x;
    }

    private void OnMouseDown()
    {
        lever.transform.Rotate(Vector3.left, changeAngle);
    }

    private void IsCorrect()
    {
        if (rotation == leverAngle1)
        {
            isCorrectlyTurned = true;
            check.CheckState();
        }
        else if(rotation == leverAngle2)
        {
            isCorrectlyTurned = true;
            check.CheckState();
        }
        else
        {
            isCorrectlyTurned = false;
            check.CheckState();
        }
    }
}

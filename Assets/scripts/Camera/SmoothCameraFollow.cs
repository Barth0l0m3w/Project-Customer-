using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public float panSpeed = 40f;
    public float panBorder = 100f;
    public float panBorderSide = 300f;

    public float panLimit;

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.mousePosition.y >= Screen.height - panBorder)
        {
            movement.z -= 1;
            movement.x -= 1;
        }
        if (Input.mousePosition.y <= panBorder)
        {
            movement.z += 1;
            movement.x += 1;
        }
        if (Input.mousePosition.x >= Screen.width - panBorderSide)
        {
            movement.z += 1;
            movement.x -= 1;
        }
        if (Input.mousePosition.x <= panBorderSide)
        {
            movement.z -= 1;
            movement.x += 1;
        }
        movement = movement.normalized * panSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);


        Vector3 pos = transform.position;
        pos.z = Mathf.Clamp(pos.z, -panLimit, panLimit);
        pos.x = Mathf.Clamp(pos.x, -panLimit, panLimit);
        transform.position = pos;
    }
}
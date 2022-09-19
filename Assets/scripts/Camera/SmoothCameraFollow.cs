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
        Vector3 pos = transform.position;
        if (Input.mousePosition.y >= Screen.height - panBorder)
        {
            pos.z -= panSpeed * Time.deltaTime;
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= panBorder)
        {
            pos.z += panSpeed * Time.deltaTime;
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - panBorderSide)
        {
            pos.z += panSpeed * Time.deltaTime;
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= panBorderSide)
        {
            pos.z -= panSpeed * Time.deltaTime;
            pos.x += panSpeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, -panLimit, panLimit);
        pos.z = Mathf.Clamp(pos.z, -panLimit, panLimit);

        transform.position = pos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public LayerMask layersToHit;
    private Vector3 worldPosition;
    private Vector3 screenPosition;

    void Update()
    {
        screenPosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(screenPosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit, 1000, layersToHit))
        {
            worldPosition = raycastHit.point;
        }
        transform.position = worldPosition;
    }
}

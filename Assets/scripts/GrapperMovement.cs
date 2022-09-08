using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapperMovement : MonoBehaviour
{
    
    public float speed = 10f;
    Vector3 tempPos;



    void Start()
    {
         tempPos = transform.position;
        
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            tempPos.z += speed;

        }
    }


    //void OnMouseDrag()
    //{
    //  Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
    //Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    //transform.position = objPosition;
    //rb.isKinematic = true;
    //}

    //private void OnMouseUp()
    //{
    //  rb.isKinematic = false;
    //}


}

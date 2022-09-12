using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GrapperMovement : MonoBehaviour
{
    
    public float speed = 10f;
    public GameObject spawnpoint;
    public GameObject Uranium;
    private float time = 0f;
    private float timeBetweenShooting = 0.5f;
    private List<GameObject> fuelList = new List<GameObject>();
    private int maxSpawnAmount = 5;

    bool yourMother = false;

    void Start()
    {
     
        
    }

    void Update()
    {



        if (yourMother == true) {
            CheckIfShouldShoot();
        }


        //Movement
        if (Input.GetKey(KeyCode.A))
         {
       
        transform.localPosition += new Vector3(0,0, speed);

        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.localPosition += new Vector3(0, 0, -speed);

        }

        //DEBUG
        if (Input.GetKey(KeyCode.E))
        {
            SetFuel();
        }

      
    }
    
    void CheckIfShouldShoot()
    {
        if (time < Time.time)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Shoot();
                time = Time.time + timeBetweenShooting;
                
            }
            
        }
        
    }

    void Shoot()
    {
        if (fuelList.Count < maxSpawnAmount)
        {
            fuelList.Add(Instantiate(Uranium, spawnpoint.transform.position, spawnpoint.transform.rotation));
        }
        
            
        
    }

   public void SetFuel()
    {
        fuelList.Clear();
        yourMother = true;
    }
}

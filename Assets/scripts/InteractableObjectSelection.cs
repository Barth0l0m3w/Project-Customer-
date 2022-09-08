using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InteractableObjectSelection : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;
    public GameObject buildingOne;
    public GameObject buildingTwo;

    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        renderers.material.color = Color.red;
        if (gameObject.name.Equals("buildingOne"))
        {
            Debug.Log("clicked building one");
        }
    }

    private void OnMouseExit()
    {
        renderers.material.color = startingColor;
    }

    private void OnMouseDown()
    {
        if (gameObject.name.Equals("BuildingOne"))
        {
            Debug.Log("clicked building one");
            SceneManager.LoadScene("insideBuildingOne");
        }

        if (gameObject.name.Equals("BuildingTwo"))
        {
            Debug.Log("clicked building two");
            SceneManager.LoadScene("insideBuildingTwo");
        }
    }
}

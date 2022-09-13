using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InteractableObjectSelection : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;
    //public GameObject buildingOne;
    //public GameObject buildingTwo;

    public string sceneName;

    public string content;
    public string header;

    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    private void OnMouseEnter()
    {
        renderers.material.color = Color.red;
        ToolTipSystem.Show(content, header);
    }

    private void OnMouseExit()
    {
        renderers.material.color = startingColor;
        ToolTipSystem.Hide();
    }

    private void OnMouseDown()
    {
        /*if (gameObject.name.Equals("BuildingOne"))
        {
            Debug.Log("clicked building one");
            SceneManager.LoadScene("insideBuildingOne");
        }*/

        Debug.Log("clicked" + sceneName);
        SceneManager.LoadScene(sceneName);

    }
}

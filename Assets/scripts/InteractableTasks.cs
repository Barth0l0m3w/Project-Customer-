using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableTasks : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;

    public string sceneName;
    public bool selected = false;
    public int selectNumber;


    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    void Update()
    {
        if (OrderMaker.task == selectNumber)
        {
            selected = true;
        }
        else
        {
            selected = false;
        }
    }

    private void OnMouseEnter()
    {
        if (selected)
        {
            renderers.material.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        renderers.material.color = startingColor;
    }

    private void OnMouseDown()
    {
        if (selected)
        {
            SceneManager.LoadScene(sceneName);
            OrderMaker.task++;
        }
    }
}

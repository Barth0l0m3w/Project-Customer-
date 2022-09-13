using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InteractableObjectSelection : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;

    public string sceneName;

    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    private void OnMouseEnter()
    {
        renderers.material.color = Color.red;
        ToolTipSystem.Show();
    }

    private void OnMouseExit()
    {
        renderers.material.color = startingColor;
        ToolTipSystem.Hide();
    }

    private void OnMouseDown()
    {
        Debug.Log("clicked" + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}

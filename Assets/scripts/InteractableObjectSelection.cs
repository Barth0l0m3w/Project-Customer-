using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InteractableObjectSelection : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;
    public ToolTipSystem tooltipSystem;

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
        tooltipSystem.Show(content, header);
    }

    private void OnMouseExit()
    {
        renderers.material.color = startingColor;
        tooltipSystem.Hide();
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}

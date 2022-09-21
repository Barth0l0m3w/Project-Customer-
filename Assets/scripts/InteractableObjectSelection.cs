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
        if (GameManager.Instance.InUIMode) return;

        renderers.material.color = Color.red;

        if (tooltipSystem != null)
        {
            tooltipSystem.Show(content, header);
        }
    }

    private void OnMouseExit()
    {
        if (GameManager.Instance.InUIMode) return;

        renderers.material.color = startingColor;

        if (tooltipSystem != null)
        {
            tooltipSystem.Hide();
        }
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}

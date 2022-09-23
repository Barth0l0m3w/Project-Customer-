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

    public int selectNumber;
    private bool selected = false;

    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    void Update()
    {
        if (OrderMaker.order == selectNumber)
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
        if (GameManager.Instance.InUIMode) return;

        if (selected)
        {
            renderers.material.color = Color.red;
            FindObjectOfType<AudioManager>().Play("BtnHover");

            if (tooltipSystem != null)
            {
                tooltipSystem.Show(content, header);
            }
        }

    }

    private void OnMouseExit()
    {
        if (GameManager.Instance.InUIMode) return;

        if (selected)
        {
            renderers.material.color = startingColor;

            if (tooltipSystem != null)
            {
                tooltipSystem.Hide();
            }
        }
    }

    private void OnMouseDown()
    {
        if (GameManager.Instance.InUIMode) return;

        if (selected)
        {
            SceneManager.LoadScene(sceneName);
            OrderMaker.order++;
        }
    }
}

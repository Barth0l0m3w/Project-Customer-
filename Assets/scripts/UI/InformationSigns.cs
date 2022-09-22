using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationSigns : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;

    public GameObject informationUI;

    private bool hovering;

    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    private void OnMouseEnter()
    {
        if (GameManager.Instance.InUIMode) return;

        renderers.material.color = Color.red;
        hovering = true;
    }

    private void OnMouseExit()
    {
        if (GameManager.Instance.InUIMode) return;

        renderers.material.color = startingColor;
        hovering = false;
    }

    private void OnMouseDown()
    {
        if (hovering)
        {
            GameManager.Instance.InUIMode = true;
            informationUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ExitInformation()
    {
        GameManager.Instance.InUIMode = false;
        informationUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

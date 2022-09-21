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
        Debug.Log("hovering");
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
            informationUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ExitInformation()
    {
        informationUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

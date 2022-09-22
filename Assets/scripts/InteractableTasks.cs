using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableTasks : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;

    public string sceneName;
    private bool selected = false;
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
        if (GameManager.Instance.InUIMode) return;

        if (selected)
        {
            renderers.material.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        if (GameManager.Instance.InUIMode) return;

        renderers.material.color = startingColor;
    }

    private void OnMouseDown()
    {
        if (GameManager.Instance.InUIMode) return;

        if (selected)
        {
            SceneManager.LoadScene(sceneName);
            Time.timeScale = 1f;
            OrderMaker.task++;
        }
    }
}

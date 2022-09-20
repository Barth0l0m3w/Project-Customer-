using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipSystem : MonoBehaviour
{
    private ToolTipSystem current;

    public Tooltip tooltip;

    private void Awake()
    {
        current = this;
        Hide();
    }

    public void Show(string content, string header = "")
    {
        if (current == null)
        {
            Debug.Log("is Null");
        }
        else
        {
            current.tooltip.SetText(content, header);
            current.tooltip.gameObject.SetActive(true);
        }

    }

    public void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipSystem : MonoBehaviour
{
    private static ToolTipSystem current;

    public Tooltip tooltip;

    private void Awake()
    {
        current = this;
        ToolTipSystem.Hide();
    }

    public static void Show(string content, string header = "")
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

    public static void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}

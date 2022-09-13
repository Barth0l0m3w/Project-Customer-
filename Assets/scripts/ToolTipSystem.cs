using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipSystem : MonoBehaviour
{
    private static ToolTipSystem current;

    public Tooltip tooltip;

    // Start is called before the first frame update
    private void Awake()
    {
        current = this;
        ToolTipSystem.Hide();
    }

    public static void Show()
    {
        current.tooltip.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}

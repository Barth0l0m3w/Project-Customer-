using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjectSelection : MonoBehaviour
{
    private Color startingColor;
    private Renderer renderers;

    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponent<Renderer>();
        startingColor = renderers.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        renderers.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderers.material.color = startingColor;
    }
}

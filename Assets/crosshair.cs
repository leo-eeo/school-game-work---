using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    private bool isGameStarted = false;
    private Renderer crosshairRenderer;



    // Start is called before the first frame update
    void Start()
    {
        crosshairRenderer = GetComponent<Renderer>();
        SetVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetVisibility(bool isVisible)
    {
        if (crosshairRenderer != null)
        {
            crosshairRenderer.enabled = isVisible;
        }
       
    }



}

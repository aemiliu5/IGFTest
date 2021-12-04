using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class Demo : MonoBehaviour
{
    public Renderer sphere;
    public Slider dissolveSlider;
    
    private void Update()
    {
        // Apply dissolve shader
        sphere.material.SetFloat("_DissolveFactor", dissolveSlider.value);
        
        // Quit on Escape
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}

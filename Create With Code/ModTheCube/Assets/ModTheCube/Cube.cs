using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private Material material;
    private float lastColorSet;
    private float setColorDelay = 5f;
    private Vector3 scaleChange = new Vector3(0.001f, 0.001f, 0.001f);

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(Random.Range(20f, 60f) * Time.deltaTime, 0.0f, 0.0f);

        transform.localScale += scaleChange;

        if (Time.time > lastColorSet + setColorDelay)
        {
            lastColorSet = Time.time;
            material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}

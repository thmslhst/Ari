using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetallicSine : MonoBehaviour
{
    public float speed = 0.1f;
    public float amplitude = 1.0f;
    public float offset = 0.0f;
    private Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();
    }

    void Update()
    {
        r.material.SetFloat("_Metallic", Mathf.Sin((Time.time + offset) * speed) * amplitude);
    }
}
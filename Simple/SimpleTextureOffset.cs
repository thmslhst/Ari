using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTextureOffset : MonoBehaviour
{
    public float flowX = 1.0f;
    public float flowY = 1.0f;
    private Vector2 _flow;
    private Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();
    }

    void Update()
    {
        _flow.x += flowX * 0.00001f;
        _flow.y += flowY * 0.00001f;
        r.material.SetTextureOffset("_BaseMap", _flow);
    }
}

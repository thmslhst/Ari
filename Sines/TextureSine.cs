using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSine : MonoBehaviour
{
    public float speed = 0.1f;
    public float amplitude = 1.0f;
    public Vector2 direction;
    public float offset = 0.0f;
    private Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();
    }

    void Update()
    {
        r.material.SetTextureOffset("_BaseMap", direction * (Mathf.Sin((Time.time + offset) * speed) * amplitude));
    }
}

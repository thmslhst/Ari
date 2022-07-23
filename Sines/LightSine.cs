using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSine : MonoBehaviour
{
    public float speed = 0.1f;
    public float amplitude = 1.0f;
    public float offset = 0.0f;
    private Light _light;

    void Start()
    {
        _light = GetComponent<Light>();
    }

    void Update()
    {
        _light.intensity = Mathf.Sin((Time.time + offset) * speed) * amplitude;
    }
}

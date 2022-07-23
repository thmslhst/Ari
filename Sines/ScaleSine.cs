using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSine : MonoBehaviour
{
    public float speed = 1.0f;
    public float sineOffset = 0.0f;
    public float scaleOffset = 1.0f;
    public float amplitude = 1.0f;

    void Update()
    {
        float scale = scaleOffset + (Mathf.Sin((Time.time + sineOffset) * speed) * amplitude);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}

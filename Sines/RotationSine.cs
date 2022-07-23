using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSine : MonoBehaviour
{
    public float speed = 0.001f;
    public float offset = 0.0f;
    public Vector3 rotationDirection;
    public bool randomize;
    public ChronoTrigger trigger;
    private Vector3 _rotation;

    void Start()
    {
        _rotation = transform.rotation.eulerAngles;

        if (trigger != null)
            trigger.Fire += RandomizeRotation;

        if (randomize)
            RandomizeRotation();
    }

    void Update()
    {
        float s = Mathf.Sin((Time.time + offset) * speed);
        Vector3 rotation = _rotation + Vector3.Scale(rotationDirection, new Vector3(s, s, s));
        transform.rotation = Quaternion.Euler(rotation);
    }

    private void RandomizeRotation()
    {
        rotationDirection = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }
}
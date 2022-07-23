using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSine : MonoBehaviour
{
    public float speed = 1.0f;
    public float offset = 0.0f;
    public Vector3 direction;
    public bool randomize;
    public ChronoTrigger trigger;
    private Vector3 _position;

    void Start()
    {
        _position = transform.position;

        if (trigger != null)
            trigger.Fire += RandomizeDirection;

        if (randomize)
            RandomizeDirection();
    }

    void Update()
    {
        float s = Mathf.Sin((Time.time + offset) * speed);
        Vector3 d = Vector3.Scale(direction, new Vector3(s, s, s));
        transform.position = _position + d;
    }

    private void RandomizeDirection()
    {
        direction = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }
}
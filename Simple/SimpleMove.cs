using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{   
    public float speed = 0.1f;
    public Vector3 direction;
    public GameObject loopCollider;
    public bool randomizeDirection = false;
    private Vector3 _basePosition;

    void Start()
    {
        _basePosition = transform.position;
        if (randomizeDirection)
            RandomizeDirection();
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    private void RandomizeDirection()
    {
        direction = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }

    void OnTriggerExit(Collider other)
    {
        if (other == loopCollider.GetComponent<BoxCollider>())
            transform.position = _basePosition;
    }
}
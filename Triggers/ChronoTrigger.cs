using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoTrigger : MonoBehaviour
{
    public delegate void Callback();
    public Callback Fire;
    public float timeLeft = 5;
    private float _timeLeft;

    void Start()
    {
        _timeLeft = timeLeft;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            Fire();
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        timeLeft = _timeLeft;
    }
}

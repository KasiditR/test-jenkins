using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopLeftRight : MonoBehaviour
{
    public float distance = 2.0f;  // Adjust this to set the distance of the loop.
    public float speed = 2.0f;     // Adjust this to set the speed of the loop.
    private Vector3 startPosition;
    private float direction = 1.0f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.PingPong(Time.time * speed, distance);
        transform.position = (startPosition + (Vector3.right * newPosition)) * direction;
    }
}

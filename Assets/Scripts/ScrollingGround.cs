using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 startPosition;
    public float resetPosition = -10.0f;
    public float startPositionReset = 10.0f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (transform.position.x <= resetPosition)
        {
            transform.position = new Vector3(startPositionReset, transform.position.y, transform.position.z);
        }
    }
}

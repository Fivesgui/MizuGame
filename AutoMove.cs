using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 2.0f; // Adjust the speed as needed
    public float distance = 5.0f; // Adjust the distance to travel

    private Vector3 initialPosition;
    private float direction = 1.0f;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the new position of the object
        Vector3 newPosition = transform.position + Vector3.right * speed * direction * Time.deltaTime;

        // Check if the object has reached its maximum distance
        if (Vector3.Distance(initialPosition, newPosition) >= distance)
        {
            // Change direction when the object reaches the maximum distance
            direction *= -1.0f;
        }

        // Update the object's position
        transform.position = newPosition;
    }
}

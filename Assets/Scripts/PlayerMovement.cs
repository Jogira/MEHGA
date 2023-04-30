using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.05f;
    float xDirection;
    float yDirection;
    public float leftBound = -10;
    public float rightBound = 10;
    public float lowerBound = -2;

    // Update is called once per frame
    void Update()
    {

        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, yDirection, 0.0f);

        transform.position += moveDirection * speed;

        ForceInBounds();

    }

    void ForceInBounds()
    {
        if (transform.position.y < lowerBound)
        {
            transform.position = new Vector3(transform.position.x, lowerBound, transform.position.z);
        }
        if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }
    }
}

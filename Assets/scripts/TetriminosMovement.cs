using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetriminosMovement : MonoBehaviour
{
    public float speed;
    private float delayOfFalling = 1f;
    private bool touchedBottom = false;
    private float lastLoopTime;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        StartCoroutine(DelayFalling(touchedBottom));
    }

    void Movement()
    {
        Vector3 currentPosition = transform.position;
        int horizontalInput = 0;
        int verticalInput = 0;

        if (Input.GetKeyDown(KeyCode.RightArrow))
            horizontalInput = 1;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            horizontalInput = -1;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            verticalInput = -1;

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        transform.position = currentPosition + movement;
    }

    IEnumerator DelayFalling(bool touchedBottom)
    {
        while (!touchedBottom)
        {
            if (Time.time - lastLoopTime >= delayOfFalling)
            {
                Falling();
                lastLoopTime = Time.time;
            }

            yield return null;
        }
    }

    void Falling()
    {
        Vector3 currentPosition = transform.position;
        int verticalInput = -1;

        Vector3 falling = new Vector3(0f, verticalInput, 0f);
        transform.position = currentPosition + falling;
    }
}

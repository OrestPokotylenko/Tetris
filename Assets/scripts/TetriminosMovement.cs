using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetriminosMovement : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        int horizontalInput = 0;
        int verticalInput = 0;

        if (Input.GetKey(KeyCode.RightArrow))
            horizontalInput = 1;
        else if (Input.GetKey(KeyCode.LeftArrow))
            horizontalInput = -1;
        else if (Input.GetKey(KeyCode.DownArrow))
            verticalInput = -1;

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        transform.position = currentPosition + movement;
    }
}

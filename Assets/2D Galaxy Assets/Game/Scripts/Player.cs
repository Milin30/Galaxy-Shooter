using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    public float horizontalInput;
    public float verticalInput;
    private void Start()
    {
        // current pos = new position
        transform.position = new Vector3(0, 0, 0);
        speed = 10;
    }

    // Update is called once per frame
    private void Update()
    {
      Movement();
    }
    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);


        //if player on the y axis reaches a value greater than 0
        //set player position to 0

        if (transform.position.y > 4.2)
        {
            transform.position = new Vector3(transform.position.x, 4.2f, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        //if player position on the y axis is greater than 9.5
        //set position on the x axis to -9.5

        if (transform.position.x > 9.5)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }

        // Potoooo
    }
}

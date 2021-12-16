using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLight : MonoBehaviour
{
    public float speed = 3f;
    private bool movingRight = true;
    private bool movingUp = true;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 2)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= -5)
            {
                movingRight = true;
            }

            if (movingUp)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                if (transform.position.y >= 8)
                {
                    movingUp = false;
                }
            }
            else
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                if (transform.position.y <= 5)
                {
                    movingUp = true;
                }
            }
        }
    }
}
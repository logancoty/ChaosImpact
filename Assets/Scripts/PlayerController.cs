using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private float jumpForce = 350;
    private Rigidbody body;
    float timer = 0f;
    float jumpTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void Update()
    {
        float horizontalForce = Input.GetAxis("Horizontal") * speed/2;
        float verticalForce = Input.GetAxis("Vertical") * speed;
        timer += Time.deltaTime;
        jumpTimer += Time.deltaTime;

        if (jumpTimer >= 1 && (Input.GetKeyDown(KeyCode.Space)))
        {
            body.AddForce(0, jumpForce, 0);
            jumpTimer = 0;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            body.AddForce(0, -1 * jumpForce/2, 0);
        }

        {
            body.AddForce(new Vector3(horizontalForce, 0, 0));
        }

        if (timer >= 10)
        {
            speed += 2f;
            timer = 0f;
        }
    }
}

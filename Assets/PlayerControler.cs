using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody rb3D;
    float moveHorizontal;
    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        rb3D = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        if (moveHorizontal > 0)
        {
            rb3D.AddForce(Vector2.right * speed, ForceMode.Impulse);
        }

        if (moveHorizontal < 0)
        {
            rb3D.AddForce(Vector2.left * speed, ForceMode.Impulse);
        }
    }
}

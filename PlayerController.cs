using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 7.0f;
    private float horizontalMove;
    private float verticalMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        if (transform.position.z < -5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4);
        } else if (transform.position.z > 5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 4);
        }

        if (transform.position.x > 25)
        {
            transform.position = new Vector3(24, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed *  horizontalMove);
        transform.Translate(Vector3.left * Time.deltaTime * speed *  verticalMove);

    }
}

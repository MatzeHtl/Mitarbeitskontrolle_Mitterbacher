using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float leftshiftspeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Horizontal, 0.0f ,Vertical);
        transform.position += movement * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftShift))
        { 
            transform.position += movement * leftshiftspeed * Time.deltaTime;
        }
        else
        {
            transform.position += movement * speed * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    private Rigidbody rb;
    private float distance;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        distance = 25.6f;
        rb.velocity = new Vector3(0,0,speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > distance)
        {
            //reposition
            Vector3 mv = new Vector3(0,0,distance *7f);
            transform.position -= mv;
        }
    }
}

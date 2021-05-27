using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadLoop : MonoBehaviour
{
    private Rigidbody rb;
    private float distance;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        distance = 96;
        rb.velocity = new Vector3(0,0,speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > distance)
        {
            //reposition
            Vector3 mv = new Vector3(0,0,distance *3f);
            transform.position -= mv;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIncoming : MonoBehaviour
{
    private float speed;
    private bool blocked;
    private Vector3 strafe;
    //private Vector3 pushback;
    
    void Start()
    {
        speed = 20f;
        blocked = false;
        Random.InitState((int) Time.time);

        strafe = new Vector3(0, 0, 0.5f);
        //pushback = new Vector3(0.05f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (blocked)
        {
            transform.position += strafe;
        }
        else
        if(transform.position.z < 14)
        {
            Vector3 mov = new Vector3(0, 0, speed*Time.deltaTime);
            transform.position += mov;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            blocked = true;
            if(Random.value > 0.5f)
                strafe *= -1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            blocked = false;
        }
    }
}

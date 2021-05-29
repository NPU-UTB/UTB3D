using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasing : MonoBehaviour
{
    public GameObject player;
    private float zSpeed;
    private float xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        zSpeed = 0.001f;
        xSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float dx = player.transform.position.x - transform.position.x;
        if (dx > 1f)
        {
            if (xSpeed < 0.05)
                xSpeed +=  0.001f;
        }
        else
        if (dx < -1.6f)
        {
            if (xSpeed > -0.05)
                xSpeed -=  0.001f;
        }
        else
            xSpeed *= 0.995f;
        if(transform.position.z < 14)
        {
            Vector3 mov = new Vector3(xSpeed, 0, -zSpeed);
            transform.position += mov;
        }
    }
}

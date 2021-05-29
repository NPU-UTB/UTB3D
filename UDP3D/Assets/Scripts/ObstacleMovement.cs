using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 13)
        {
            Vector3 mov = new Vector3(0, 0, speed*Time.deltaTime);
            transform.position += mov;
        }
    }
}

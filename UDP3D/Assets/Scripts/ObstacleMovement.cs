using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject obst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(obst.transform.position.z < 13)
        {
            Vector3 mov = new Vector3(0, 0, speed*Time.deltaTime);
            obst.transform.position += mov;
        }
    }
}

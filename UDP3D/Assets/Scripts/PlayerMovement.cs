using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float hSpeed;
    private float baseSpeed = 0.1f;
    private float resistance = 0.005f;
    public GameObject player;
    public Camera cam;
    void Start()
    {
        hSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.touchCount >0)
        {
            Touch tap = Input.GetTouch(0);
            Vector3 tpos = cam.ScreenToViewportPoint(tap.position);
            if (tpos.x > 0.5)
            {
                hSpeed = -baseSpeed;
            }
            else if (tpos.x < 0.5)
            {
                hSpeed = baseSpeed;
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 hmov = new Vector3(hSpeed, 0, 0);
        player.transform.position += hmov;
        if(hSpeed > 0)
            hSpeed -= resistance;
        else if (hSpeed < 0)
        {
            hSpeed += resistance;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float hSpeed;
    private float baseSpeed = 4f;
    private float resistance = 0.05f;
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
            Vector3 tpos = Camera.main.ScreenToWorldPoint(tap.position);
            if (tpos.x > transform.position.x)
            {
                hSpeed = baseSpeed;
            }
            else if (tpos.x < transform.position.x)
            {
                hSpeed = -baseSpeed;
            }
        }
        else
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 tpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (tpos.x > transform.position.x)
            {
                hSpeed = baseSpeed;
            }
            else if (tpos.x < transform.position.x)
            {
                hSpeed = -baseSpeed;
            }
            Debug.DrawLine(Vector3.zero, tpos, Color.red);
        }
    }

    void FixedUpdate()
    {
        Vector3 hmov = new Vector3(hSpeed, 0, 0);
        transform.position += hmov;
        if(hSpeed > 0)
            hSpeed -= resistance;
        else if (hSpeed < 0)
        {
            hSpeed += resistance;
        }
    }
}

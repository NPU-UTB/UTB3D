using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBack : MonoBehaviour
{
    private bool slowed;
    private bool blocked;
    private Vector3 hurry;
    private Vector3 slow;
    private Vector3 pushback;
    // Start is called before the first frame update
    void Start()
    {
        slowed = false;
        blocked = false;
        hurry = new Vector3(0, 0, 0.01f);
        pushback = new Vector3(0, 0, 0.5f);
        slow = new Vector3(0, 0, 0.005f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slowed)
        {
            transform.position += slow;
        }
        else
        if (transform.position.z > 6 && !blocked)
        {
            transform.position -= hurry;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Bonk!");
        if (other.gameObject.tag == "Obstacle")
        {
            blocked = true;
            transform.position += pushback;
        }
        else
        if (other.gameObject.tag == "Road")
        {
            slowed = true;
        }
        else
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Chaser")
        {
            //koniec gry
            Debug.Log("Game Over, man!");
            FindObjectOfType<PlayerState>().TheEnd();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            blocked = false;
        }
        if (other.gameObject.tag == "Road")
        {
            slowed = false;
        }
    }
}

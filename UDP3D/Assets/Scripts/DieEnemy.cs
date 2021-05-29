using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Bonk!");
        if (other.gameObject.tag == "Goo")
        {
            Destroy(gameObject);
            Score counter = GetComponent<Score>();
            counter.upOne();
        }
    }
}

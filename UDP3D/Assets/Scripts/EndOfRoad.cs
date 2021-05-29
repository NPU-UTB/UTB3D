using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfRoad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Bonk!");
        if (other.gameObject.tag == "Player")
        {
            //koniec gry...
            Debug.Log("Game Over, man!");
            FindObjectOfType<PlayerState>().TheEnd();
        }
        else
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Score counter = FindObjectOfType<Score>();
            counter.upOne();
        }
        else
        if (other.gameObject.tag == "Chaser")
        {
            Destroy(other.gameObject);
            Score counter = FindObjectOfType<Score>();
            counter.upOne();
            ChaserSpawner sp = FindObjectOfType<ChaserSpawner>();
            sp.alive = false;
        }
        else
        if (other.gameObject.tag != "Road")
        {
            Destroy(other.gameObject);
        }
    }
}

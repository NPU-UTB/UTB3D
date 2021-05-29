using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] stuff;
    private float spawnCd;
    private float timer;
    private float[] points = {-3.5f, 0f, 3.5f};
    // Start is called before the first frame update
    void Start()
    {
        spawnCd = 5f;
        timer = 0;
        Random.InitState((int)Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnCd)
        {
            timer = 0f;
            GameObject obj = stuff[Random.Range(0, stuff.Length)];
            Vector3 sp = new Vector3(points[Random.Range(0,3)], 1 ,-120);
            Instantiate(obj, sp, Quaternion.identity);
        }
    }
}

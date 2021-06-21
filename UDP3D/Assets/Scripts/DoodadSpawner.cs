using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodadSpawner : MonoBehaviour
{
    public GameObject[] stuff;
    public GameObject[] trees;
    public GameObject[] buildings;
    private float spawnCd;
    private float timer;
    private float[] points = {-12f, 12f};//do zamiany...
    private int areaNo;
    private int objPerAreaBase;
    private int objPerArea;
    private int objCounter;
    private float sign;
    void Start()
    {
        spawnCd = 2f;
        timer = 1f;

        objPerArea = objPerAreaBase = 8;
        objCounter = 0;
        sign = 1;

        Random.InitState((int)Time.time);
        areaNo = Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = null;
        float x = 0;
        //trees & stuff: 12 +8*(0-4)
        //buildings: 15*(1-3)
        timer += Time.deltaTime;
        if (timer >= spawnCd)
        {
            timer = 0f;
            if (areaNo == 0) //stuff
            {
                obj = stuff[Random.Range(0, stuff.Length)];
                x = sign*(12+8*Random.Range(0,5));
            }
            else
            if (areaNo == 1) //trees
            {
                obj = trees[Random.Range(0, trees.Length)];
                x = sign*(12+8*Random.Range(0,5));
            }
            else //buildings
            {
                obj = buildings[Random.Range(0, buildings.Length)];
                x = sign*(15*Random.Range(1,4));
            }
            Vector3 sp = new Vector3(x, obj.transform.position.y ,-120);
            Instantiate(obj, sp, Quaternion.identity);
            sign *= -1;
            objCounter += 1;

            if (objCounter >= objPerArea)
            {
                objCounter = 0;
                areaNo = Random.Range(0,3);
                objPerArea = objPerAreaBase + Random.Range(-4,5);
            }
        }
    }
}

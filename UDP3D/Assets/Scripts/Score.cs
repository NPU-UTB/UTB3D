using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    void Start()
    {
        score = 0;
    }

    public void upOne()
    {
        score += 1;
    }

    public int getScore()
    {
        return score;
    }
}

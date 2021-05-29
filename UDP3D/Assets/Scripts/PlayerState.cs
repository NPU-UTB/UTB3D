using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public GameObject bike;
    public GameObject endScreen;
    public Text text;
    // Start is called before the first frame update
    public void TheEnd()
    {
        bike.SetActive(false);
        Invoke("TheRealEnd", 3f);
    }

    private void TheRealEnd()
    {
        endScreen.SetActive(true);
        text.text = "YOUR SCORE: " + FindObjectOfType<Score>().getScore();
    }
}

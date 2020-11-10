using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TetrisBlock tetris;
    public Text text;

    void Start()

    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

       // text.text = "Score: " + tetris.scoretext;

    }
}

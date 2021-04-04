using System;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text pointsText;

    internal int points;
    private int highscore;

    private void Start()
    {
        points = 0;
        pointsText.text = $"{points} HEXES";

        highscore = PlayerPrefs.GetInt("Highscore");
    }

    private void Update()
    {
        if (points > highscore)
        {
            highscore = points;

            PlayerPrefs.SetInt("Highscore", highscore);
        }

        pointsText.text = $"{points} HEXES\n" +
                          $"{highscore} HIGHSCORE";
    }
}

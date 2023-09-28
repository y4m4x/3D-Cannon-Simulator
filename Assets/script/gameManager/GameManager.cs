using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int counter;

    void ScoreText()
    {
        counter++;
        scoreText.text = "SCORE: " + counter;
    }

    private void OnEnable()
    {
        Barrel.scoreEvent += ScoreText;
    }

    private void OnDisable()
    {
        Barrel.scoreEvent -= ScoreText;
    }
}

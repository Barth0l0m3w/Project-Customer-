using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateText()
    {
        scoreText.text = "Fuel 1 / " + score.ToString();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateText();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : Singleton<Score>
{
    [SerializeField] private TextMeshProUGUI scoreBoxText;
    [SerializeField] public int currentScore;

    private void Update()
    {
        UpdateScoreBox();
    }
    void LoadScoreBox()
    {
        if (scoreBoxText != null) return;
        scoreBoxText = GetComponent<TextMeshProUGUI>();
    }

    private void Reset()
    {
        LoadScoreBox();
    }
    void UpdateScoreBox()
    {
        scoreBoxText.text = currentScore.ToString();
    }
}

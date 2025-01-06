using UnityEngine;
using TMPro;

internal class ScoreManager : MonoBehaviour
{
    private int _score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        GameEvents.Instance.OnObstaclePassed += IncrementScore;
        GameEvents.Instance.OnGameEnd += ResetScore;
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnObstaclePassed -= IncrementScore;
        GameEvents.Instance.OnGameEnd -= ResetScore;
    }

    private void IncrementScore()
    {
        _score++;
        scoreText.text = "Score: " + _score;
    }

    private void ResetScore()
    {
        _score = 0;
        scoreText.text = "Score: 0";
    }
}

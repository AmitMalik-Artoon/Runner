using UnityEngine;

internal class Manager : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.Instance.OnGameEnd += HandleGameEnd;
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnGameEnd -= HandleGameEnd;
    }

    private void HandleGameEnd()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Over!");
        // Optionally, show Game Over UI here.
    }
}

using UnityEngine;

internal class BoundaryController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            GameEvents.Instance.OnObstaclePassed?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}

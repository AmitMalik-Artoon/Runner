using UnityEngine;

internal class ObstacleController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

}

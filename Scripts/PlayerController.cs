using UnityEngine;

internal class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float jumpForce = 10f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Jump();
        }
    }

    private bool IsGrounded()
    {
        // Ground check logic
        return Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
    }

    private void Jump()
    {
        _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameEvents.Instance.OnGameEnd?.Invoke();
        }
    }
}

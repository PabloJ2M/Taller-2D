using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Vector2 input = new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb.MovePosition(rb.position + input * _speed * Time.fixedDeltaTime);
    }
}
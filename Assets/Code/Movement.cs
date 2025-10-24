using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private Rigidbody2D rb;
    private Vector2 input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * _speed * Time.fixedDeltaTime);
    }

    private void OnMove(InputValue tecla)
    {
        input = tecla.Get<Vector2>();
    }
}
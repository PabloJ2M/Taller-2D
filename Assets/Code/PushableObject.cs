using UnityEngine;

public class PushableObject : MonoBehaviour
{
    [SerializeField] private float _speedMultiply = 1;
    private Transform _target;
    private Rigidbody2D _rb;

    private void Awake() => _rb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (_target == null) return;
        transform.position = Vector2.MoveTowards(transform.position, _target.position, Time.deltaTime);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Player")) return;
        Vector2 direction = collision.contacts[0].normal;
        _rb.MovePosition(_rb.position + direction * _speedMultiply * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Finish")) return;
        _rb.constraints = RigidbodyConstraints2D.FreezeAll;
        _target = collision.transform;
    }
}
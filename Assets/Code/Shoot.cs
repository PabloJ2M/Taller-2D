using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _prefab;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        Vector2 input = _camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (input - (Vector2)transform.position).normalized;

        Instantiate(_prefab, transform.position, Quaternion.identity)
            .AddForce(direction * 10, ForceMode2D.Impulse);

        StartCoroutine(Start());
    }
}
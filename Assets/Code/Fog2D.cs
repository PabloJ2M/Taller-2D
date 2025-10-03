using UnityEngine;

public class Fog2D : MonoBehaviour
{
    [SerializeField] private Vector2 target;
    [SerializeField] private float speed;
    [SerializeField] private AnimationCurve curve;

    private Vector2 startPoint;

    private void Start()
    {
        startPoint = transform.position;
    }
    private void Update()
    {
        Vector2 pos = transform.position;

        float time = curve.Evaluate(Time.time * speed);

        pos.y = Mathf.Lerp(startPoint.y, target.y, time);

        transform.position = pos;
    }
}
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveElement : MonoBehaviour, /*IDragHandler,*/ IPointerDownHandler, IPointerUpHandler
{
    //UI - Overlay
    //public void OnDrag(PointerEventData eventData)
    //{
    //    transform.position += (Vector3)eventData.delta;
    //}

    private Rigidbody2D body;
    private Vector2 _offset;
    private bool _isActive;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (!_isActive) return;
        
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPosition + _offset;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _offset = (Vector2)transform.position - worldPosition;
        _isActive = true;
        body.bodyType = RigidbodyType2D.Static;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _isActive = false;
        body.bodyType = RigidbodyType2D.Dynamic;
    }
}
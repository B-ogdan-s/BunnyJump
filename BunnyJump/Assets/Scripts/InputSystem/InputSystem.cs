using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputSystem : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private float _maxRadius;
    private Vector2 _downPosition;
    private Vector2 _upPosition;

    public Action<Vector2> Drag;
    public Action OnUp;

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.position - _downPosition;
        float distans = delta.sqrMagnitude;

        float a = distans / _maxRadius;

        Drag?.Invoke(-delta.normalized * a);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _downPosition = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnUp?.Invoke();
    }
}

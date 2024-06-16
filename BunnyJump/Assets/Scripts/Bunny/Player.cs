using System;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Min(5)] private float _jumpForce = 5f;
    [SerializeField, Range(0f, 1f)] private float _bounce;
    [SerializeField] private LineRenderer _lineRenderer;
    private JumpSystem _jumpSystem = new();

    public Action Destroy;

    public void DrawTrajectory(Vector2 direction)
    {
        Vector3[] steps = _jumpSystem.CalculateTrajectory(direction*_jumpForce);

        _lineRenderer.positionCount = steps.Length;

        for(int i = 0;  i < steps.Length; i++)
        {
            _lineRenderer.SetPosition(i ,steps[i]);
        }
    }
    public void ClearTrajectory()
    {
        _lineRenderer.positionCount=0;
    }

    private void OnDestroy()
    {
        Destroy?.Invoke();
    }
}

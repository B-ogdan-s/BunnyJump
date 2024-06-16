using UnityEngine;

public class JumpSystem
{
    private uint _segmentCount = 10;
    private float _timeStep = 0.1f;

    public Vector3[] CalculateTrajectory(Vector2 direction)
    {
         Vector2 _gravity = Physics2D.gravity;
         Vector3[] trajectory = new Vector3[_segmentCount];

        for(int i = 0; i < _segmentCount; i++)
        {
            float time = _timeStep * i;

            trajectory[i] = direction * time + _gravity*time*time;
        }

        return trajectory;
    }


}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private InputSystem _inputSystem;
    [SerializeField] private Player _prefabPlayer;
    [SerializeField] private byte _levelIndex;
    [SerializeField] private LevelInfo[] _levels;
    
    private Player _player;
    private LevelLogic _level;


    private void Awake()
    {
        _level = Instantiate(CheckLevelindex());
        _player = Instantiate(_prefabPlayer);
        _player.transform.position = _level.PlayerStartPosition.position;

        _inputSystem.Drag += _player.DrawTrajectory;
        _inputSystem.OnUp += _player.ClearTrajectory;
    }

    private LevelLogic CheckLevelindex()
    {
        foreach (var level in _levels)
        {
            if (level.Index == _levelIndex)
            {
                return level.Level;
            }
        }
        return _levels[0].Level;    
    }
}

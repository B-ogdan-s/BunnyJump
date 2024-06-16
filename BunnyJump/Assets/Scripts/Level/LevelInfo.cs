using System.Collections;
using UnityEngine;

[System.Serializable]
public struct LevelInfo
{
    [SerializeField] private byte _index;
    [SerializeField] private LevelLogic _level;

    public byte Index => _index;
    public LevelLogic Level => _level;
}

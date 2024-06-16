using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLogic : MonoBehaviour
{
    [SerializeField] private Transform _playerStartPosition;

    public Transform PlayerStartPosition => _playerStartPosition;
}

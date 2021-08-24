using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosMovement : MonoBehaviour
{
    [SerializeField] Transform _player;

    private void Update() {
        transform.position = _player.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Player _player;

    [SerializeField] private float _offset;

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x + _offset, transform.position.y, transform.position.z); 
    }
}

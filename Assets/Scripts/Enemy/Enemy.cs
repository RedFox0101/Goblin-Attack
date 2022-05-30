using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private Player _target;
    [SerializeField] private float _distance;

    private void Update()
    {
        if(Vector2.Distance(transform.position, _target.transform.position) > _distance)
        {
            ChangeState(StateType.Walk);
        }
        else
        {
            ChangeState(StateType.Attak);
        }
    }
}

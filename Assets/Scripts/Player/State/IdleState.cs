using UnityEngine;
using Spine.Unity;

public class IdleState : State
{
    private Rigidbody2D _rigidBody;

    private void Awake()
    {
        Skeleton = GetComponent<SkeletonAnimation>();
        _rigidBody = GetComponent<Rigidbody2D>();
        Type = StateType.Idle;
        IsReadToMove = true;
    }

    private void OnEnable()
    {
        _rigidBody.velocity = Vector2.zero;
    }
}

using UnityEngine;
using Spine.Unity;

public abstract class MoveState : State
{
    [SerializeField] protected float Speed;

    private Quaternion left = Quaternion.Euler(0, 180, 0);
    private Quaternion right = Quaternion.Euler(0, 0, 0);

    protected void Init()
    {
        IsReadToMove = true;
        Skeleton = GetComponent<SkeletonAnimation>();
        Type = StateType.Walk;
    }

    protected abstract void Move(Vector2 movement);  

    protected void ChangeLook(float flipX)
    {
        transform.localRotation = flipX < 0 ? left : right;
    }
}

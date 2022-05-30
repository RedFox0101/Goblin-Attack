using UnityEngine;
using Spine.Unity;

public abstract class State : MonoBehaviour
{
    [SerializeField] private AnimationReferenceAsset _animation;

    public StateType Type { get; protected set; }

    protected SkeletonAnimation Skeleton;

    public bool IsReadToMove { get; protected set; }

    public void Enter()
    {
        enabled = true;

        SetAnimation(_animation);
    }

    public void Exit()
    {
        enabled = false;
    }

    protected virtual void SetAnimation(AnimationReferenceAsset animation)
    {
        Skeleton.state.SetAnimation(0, animation, true);
        Skeleton.state.TimeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class DeadState : State
{
    private void Awake()
    {
        Skeleton = GetComponent<SkeletonAnimation>();
        Type = StateType.Dead;
        IsReadToMove = true;
    }

    protected override void SetAnimation(AnimationReferenceAsset animation)
    {
        Skeleton.state.SetAnimation(0, animation, false);
        IsReadToMove = false;
    }
}

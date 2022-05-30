using UnityEngine;
using Spine.Unity;

public abstract class AttackState : State
{
    [SerializeField] protected float CoolDown;
    [SerializeField] private float _speedAnimation;
    private float lastAttackTime;

    protected Spine.TrackEntry TrackEntry;

    protected void Init()
    {
        Skeleton = GetComponent<SkeletonAnimation>();
        Type = StateType.Attak;
    }

    protected abstract void Attack();

    protected virtual void RechargeAttack()
    {
        if (lastAttackTime <= 0)
        {
            lastAttackTime = CoolDown;
            Skeleton.Start();
        }
        lastAttackTime -= Time.deltaTime;
    }

    protected override void SetAnimation(AnimationReferenceAsset animation)
    {
        TrackEntry = Skeleton.state.SetAnimation(0, animation, true);
        TrackEntry.Complete += TrackEntry_Complate;
        TrackEntry.TimeScale =1/_speedAnimation;
    }

    protected void TrackEntry_Complate(Spine.TrackEntry trackEntry)
    {
        Attack();
        IsReadToMove = true;
    }
}

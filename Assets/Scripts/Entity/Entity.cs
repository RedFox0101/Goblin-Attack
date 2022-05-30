using UnityEngine;


public abstract class Entity : MonoBehaviour
{
    [SerializeField] private StateBehavior _stateBehavior;
    [SerializeField] private int _heath;

    protected void ChangeState(StateType state)
    {
        _stateBehavior.ChangeState(state);
    }

    public void TakeDamage(int damage)
    {
        _heath -= damage;

        if (_heath <= 0)
        {
            _stateBehavior.ChangeState(StateType.Dead);
        }
    }
}


using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StateBehavior : MonoBehaviour
{
    [SerializeField] private List<State> _stateEntity;
    [SerializeField] private State _firstState;

    protected State _currentState { get; private set; }

    private void Start()
    {
        Init(_firstState);
    }

    private void Init(State firstState)
    {
        foreach (var _state in _stateEntity)
        {
            _state.enabled = false;
        }

        _currentState = firstState;

        _currentState.Enter();
    }

    public void ChangeState(StateType type)
    {
        if (_currentState.IsReadToMove == false) return;

        if (type == _currentState.Type) return;

        _currentState.Exit();

        _currentState = FindState(type);

        _currentState.Enter();
    }

    private State FindState(StateType type)
    {
        return _stateEntity.First(state => state.Type == type);
    }
}

public enum StateType
{
    Attak,
    Walk,
    Idle,
    Dead
}


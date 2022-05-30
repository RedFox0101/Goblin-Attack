using UnityEngine;

[RequireComponent(typeof(InputPlayer))]
public class Player : Entity
{
    private InputPlayer _inputPlayer;

    private void Start()
    {
        _inputPlayer = GetComponent<InputPlayer>();
    }

    private void Update()
    {
        if (_inputPlayer.GetDirection().x != 0 || _inputPlayer.GetDirection().y != 0)
        {
            ChangeState(StateType.Walk);
        }
        else
        {
            ChangeState(StateType.Idle);
        }
    }

    public void Attack()
    {
        ChangeState(StateType.Attak);
    }

}

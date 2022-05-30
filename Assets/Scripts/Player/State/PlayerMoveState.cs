using UnityEngine;

[RequireComponent(typeof(InputPlayer))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoveState : MoveState
{
    private  Rigidbody2D _rigidbody;
    private InputPlayer _input;
    
    private void Start()
    {
        Init();
        _rigidbody = GetComponent<Rigidbody2D>();
        _input = GetComponent<InputPlayer>();
        
    }

    private void Update()
    {
        Move(_input.GetDirection());
    }

    protected override void Move(Vector2 movement)
    {
        _rigidbody.velocity = movement * Speed;
        ChangeLook(movement.x);
    }

}

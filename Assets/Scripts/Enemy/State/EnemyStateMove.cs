using UnityEngine;

public class EnemyStateMove : MoveState
{
    [SerializeField] private Player _target;

    private void Awake()
    {
        Init();
    }

    private void Update()
    {
        Move(_target.transform.position);
    }

    protected override void Move(Vector2 movement)
    {
       transform.position = Vector2.MoveTowards(transform.position, movement, Speed * Time.deltaTime);
       ChangeLook(movement.x);
    }
}

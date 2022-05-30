using UnityEngine;

public class EnemyStateAttack : AttackState
{
    [SerializeField] private Player _player;
    [SerializeField] private int _damage;
    private  Rigidbody2D _rigidbody;

    private void Awake()
    {
        Init();
        _rigidbody = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        RechargeAttack();
    }

    private void OnEnable()
    {
        IsReadToMove = false;
        _rigidbody.velocity = Vector2.zero;
    }

    private void OnDisable()
    {
        TrackEntry.Complete -= TrackEntry_Complate;
    }

    protected override void Attack()
    {
        _player.TakeDamage(_damage);
    }
}

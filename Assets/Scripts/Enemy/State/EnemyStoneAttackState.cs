using UnityEngine;

public class EnemyStoneAttackState : AttackState
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Bulllet _stonePrefab;

    private void Start()
    {
        Init(); 
    }

    private void OnEnable()
    {
        IsReadToMove = false;
    }

    protected override void Attack()
    {
        var bullet = Instantiate(_stonePrefab, _spawnPoint.position, transform.localRotation);
        int direction = transform.localRotation.y == 0 ? 1 : -1;
        bullet.SetDirection(direction);
    }
}

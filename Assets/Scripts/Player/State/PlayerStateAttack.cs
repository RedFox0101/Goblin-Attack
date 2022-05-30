using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateAttack : AttackState
{
    [SerializeField] private Bulllet _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;

    private InputPlayer _inputPlayer;
    private new Rigidbody2D rigidbody;
    private Quaternion _left = new Quaternion(0, 180, 0, 0);
    private Quaternion _right = new Quaternion(0, 0, 0, 0);

    public float CoolDownAttack => CoolDown;

    private void Awake()
    {
        Init();
        _inputPlayer = GetComponent<InputPlayer>();
        rigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        RechargeAttack();
        ReviewChange();
    }

    private void OnEnable()
    {
        IsReadToMove = false;
        rigidbody.velocity = Vector2.zero;
    }

    private void OnDisable()
    {
        TrackEntry.Complete -= TrackEntry_Complate;
    }

    private void ReviewChange()
    {
        if (_inputPlayer.GetDirection().x < 0)
        {
            transform.localRotation = _left;
        }
        if (_inputPlayer.GetDirection().x > 0)
        {
            transform.localRotation = _right;
        }
    }

    protected override void Attack()
    {
        var bullet = Instantiate(_bulletPrefab, _spawnPoint.position, transform.localRotation);
        int direction = transform.localRotation.y == 0 ? 1 : -1;
        bullet.SetDirection(direction);
    }
}

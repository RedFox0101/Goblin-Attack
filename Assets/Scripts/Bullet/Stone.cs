using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Stone : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    public void SetDirection(float direction)
    {
        _direction = new Vector3(direction, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}

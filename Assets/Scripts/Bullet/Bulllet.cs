using UnityEngine;

public class Bulllet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
   
    private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction*_speed*Time.deltaTime, Space.World);
        
    }

    public void SetDirection(float direction)
    {
        _direction = new Vector3(direction, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}

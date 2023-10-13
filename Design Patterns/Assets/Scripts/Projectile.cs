using UnityEngine;

public class Projectile : MonoBehaviour, IPoolable
{
    public bool Active { get; set; }
    public ProjectilePool Pool { get; set; }
    public GameObject GameObject { get => gameObject; }

    private Vector3 direction;
    private float speed;

    [SerializeField] private float lifespan;
    private float age = 0;

    public void OnActivate()
    {
        gameObject.SetActive(true);
    }

    public void OnDeactivate()
    {
        gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        gameObject.transform.Translate(speed * Time.deltaTime * direction);
        age += Time.deltaTime;
        if(age > lifespan )
        {
            Pool.DeactivateObject(this);
        }
    }

    public void Setup(Vector3 _direction, float _speed)
    {
        direction = _direction;
        speed = _speed;
        age = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();
        if(damageable != null)
        {
            Pool.DeactivateObject(this);
            damageable.TakeDamage(1);
        }
    }
}

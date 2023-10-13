using UnityEngine;

public class Weapon : MonoBehaviour, IFireable
{
    private ProjectilePool pool;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileSpeed;

    public void Start()
    {
        pool = new ProjectilePool(projectilePrefab, 20);
    }

    public void Fire(ITargetable target)
    {
        IPoolable projectile = pool.RequestObject();
        if (projectile != null)
        {
            projectile.GameObject.transform.position = gameObject.transform.position;
        }
        if (target != null)
        {
            //Not gonna implement pursuit problem algebra for this lol
            float travelTime = Vector3.Distance(target.Position, gameObject.transform.position) / projectileSpeed;
            Vector3 targetPos = target.Position + target.Velocity * travelTime;
            projectile.Setup((targetPos - gameObject.transform.position).normalized, projectileSpeed);
        }
        else
        {
            projectile.Setup(gameObject.transform.forward, projectileSpeed);
        }
    }
}

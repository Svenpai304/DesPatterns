using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoolable
{
    public bool Active { get; set; }
    public ProjectilePool Pool { get; set; }
    public GameObject GameObject { get; }
    public void OnActivate();
    public void OnDeactivate();
    public void Setup(Vector3 direction, float speed);
}

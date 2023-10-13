using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool
{
    private List<IPoolable> _activePool = new List<IPoolable>();
    private List<IPoolable> _inactivePool = new List<IPoolable>();
    private int maxCapacity;
    private GameObject prefab;

    public ObjectPool(GameObject _prefab, int _maxCapacity)
    {
        prefab = _prefab;
        maxCapacity = _maxCapacity;
    }

    public IPoolable RequestObject()
    {
        if (_inactivePool.Count > 0)
        {
            return ActivateObject(_inactivePool[0]);
        }
        if (_activePool.Count < maxCapacity)
        {
            return ActivateObject(AddNewObject());
        }
        else
        {
            return RecycleObject();
        }
    }

    private IPoolable AddNewObject()
    {
        IPoolable obj = UnityEngine.Object.Instantiate(prefab).GetComponent<IPoolable>();
        obj.Pool = this;
        _inactivePool.Add(obj);
        return obj;
    }

    private IPoolable ActivateObject(IPoolable obj)
    {
        obj.Active = true;
        obj.OnActivate();
        if (_inactivePool.Contains(obj))
        {
            _inactivePool.Remove(obj);
        }
        _activePool.Add(obj);
        return obj;
    }

    public void DeactivateObject(IPoolable obj)
    {
        if (_activePool.Contains(obj))
        {
            obj.Active = false;
            obj.OnDeactivate();
            _activePool.Remove(obj);
            _inactivePool.Add(obj);
        }
    }

    private IPoolable RecycleObject()
    {
        IPoolable obj = _activePool[0];
        _activePool.Remove(obj);
        _activePool.Add(obj);
        return obj;
    }
}

using System.Collections.Generic;

public class ObjectPool<T>
{
    private List<T> activePool;
    private List<T> inactivePool;

    public void Add(int count)
    {

    }

    public void Remove(int count)
    {

    }

    public T Request()
    {
        return inactivePool[0];
    }
}

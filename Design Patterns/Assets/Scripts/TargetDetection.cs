using UnityEngine;

public class TargetDetection
{
    public ITargetable CurrentTarget;

    public void SetTarget()
    {
        CurrentTarget = Object.FindFirstObjectByType<Target>(); // ¯\_(ツ)_/¯
        CurrentTarget.OnTargeted();
    }
}

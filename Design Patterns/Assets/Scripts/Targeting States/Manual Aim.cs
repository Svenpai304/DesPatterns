public class ManualAim : ITargetingState
{
    public ITargetingState GetNextState()
    {
        return new FreeLock();
    }

    public void Target(ITargetable target, PlayerCamera camera, ReticleController reticle)
    {
        reticle.SetToCenter();
    }
    public ITargetable GetTarget(ITargetable target)
    {
        return null;
    }
}

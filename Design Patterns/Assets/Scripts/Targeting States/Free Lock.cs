public class FreeLock : ITargetingState
{
    public ITargetingState GetNextState()
    {
        return new TargetAssist();
    }
    public void Target(ITargetable target, PlayerCamera camera, ReticleController reticle)
    {
        reticle.SetToPoint(target.Position);
    }
    public ITargetable GetTarget(ITargetable target)
    {
        return target;
    }
}

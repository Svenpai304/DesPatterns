public class TargetAssist : ITargetingState
{
    public ITargetingState GetNextState()
    {
        return new ManualAim();
    }

    public void Target(ITargetable target, PlayerCamera camera, ReticleController reticle)
    {
        camera.LookAtPoint(target.Position);
        reticle.SetToCenter();
    }

    public ITargetable GetTarget(ITargetable target)
    {
        return target;
    }
}
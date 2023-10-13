public interface ITargetingState
{
    public ITargetingState GetNextState();
    public void Target(ITargetable target, PlayerCamera camera, ReticleController reticle);
    public ITargetable GetTarget(ITargetable target);
}

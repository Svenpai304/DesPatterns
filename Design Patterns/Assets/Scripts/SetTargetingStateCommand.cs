public class SetTargetingStateCommand : ICommand
{
    private TargetingBehaviourFSM targeting;
    public SetTargetingStateCommand(TargetingBehaviourFSM _targeting)
    {
        targeting = _targeting;
    }
    public void Execute()
    {
        targeting.SetStateToNext();
    }
}

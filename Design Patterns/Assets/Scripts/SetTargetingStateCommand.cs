using UnityEngine;

public class SetTargetingStateCommand : ICommand
{
    private TargetingBehaviourFSM targeting;
    public SetTargetingStateCommand(TargetingBehaviourFSM _targeting, KeyCode key)
    {
        targeting = _targeting;
        InputHandler.Instance.AddCommand(key, this);
    }
    public void Execute()
    {
        targeting.SetStateToNext();
    }
}

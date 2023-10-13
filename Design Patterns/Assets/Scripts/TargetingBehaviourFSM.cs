using UnityEngine;

public class TargetingBehaviourFSM
{
    private TargetDetection detection;
    private SetTargetingStateCommand SetTargetingStateCommand;
    private ITargetingState currentState;
    private PlayerCamera camera;
    private ReticleController reticle;

    public TargetingBehaviourFSM(KeyCode key)
    {
        detection = new TargetDetection();
        SetTargetingStateCommand = new SetTargetingStateCommand(this, key);
        camera = Object.FindFirstObjectByType<PlayerCamera>();
        reticle = Object.FindFirstObjectByType<ReticleController>();

        detection.SetTarget();
        currentState = new ManualAim();
    }

    public void Target()
    {
        currentState.Target(detection.CurrentTarget, camera, reticle);
    }

    public ITargetable GetTarget()
    {
        return currentState.GetTarget(detection.CurrentTarget);
    }

    public void SetState(ITargetingState newState)
    {
        currentState = newState;
    }

    public void SetStateToNext()
    {
        currentState = currentState.GetNextState();
    }
}

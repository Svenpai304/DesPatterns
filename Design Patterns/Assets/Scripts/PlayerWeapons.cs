using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    public KeyCode fireKey;
    public KeyCode targetingKey;
    private TargetingBehaviourFSM targeting;
    private FireCommand fireCommand;
    private IFireable currentWeapon;

    private void Start()
    {
        currentWeapon = GetComponentInChildren<IFireable>();
        targeting = new TargetingBehaviourFSM(targetingKey);
        fireCommand = new FireCommand(this, fireKey);
    }

    private void Update()
    {
        targeting.Target();
    }

    public void Fire()
    {
        currentWeapon.Fire(targeting.GetTarget());
    }
}

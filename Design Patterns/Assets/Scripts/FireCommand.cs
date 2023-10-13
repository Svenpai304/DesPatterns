using UnityEngine;

public class FireCommand : ICommand
{
    private PlayerWeapons weapons;

    public FireCommand(PlayerWeapons _weapons, KeyCode key)
    {
        weapons = _weapons;
        InputHandler.Instance.AddCommand(key, this);
    }
    public void Execute()
    {
        Debug.Log("Firing");
        weapons.Fire();
    }
}

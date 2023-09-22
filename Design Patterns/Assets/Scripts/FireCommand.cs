public class FireCommand : ICommand
{
    private PlayerWeapons weapons;

    public FireCommand(PlayerWeapons _weapons)
    {
        weapons = _weapons;
    }
    public void Execute()
    {
        weapons.Fire();
    }
}

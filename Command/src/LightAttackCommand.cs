class LightAttackCommand : ICommand
{
    public void execute (ref Player playerReference) {
        playerReference.LightAttack();
    }
}
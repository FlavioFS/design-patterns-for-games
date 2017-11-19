class SpecialAttackCommand : ICommand
{
    public void execute (ref Player playerReference) {
        playerReference.SpecialAttack();
    }
}
class HeavyAttackCommand : ICommand
{
    public void execute (ref Player playerReference) {
        playerReference.HeavyAttack();
    }
}
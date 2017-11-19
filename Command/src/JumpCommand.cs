class JumpCommand : ICommand
{
    public void execute (ref Player playerReference) {
        playerReference.Jump();
    }
}
class InputManager
{
    private ICommand buttonA;
    private ICommand buttonB;
    private ICommand buttonX;
    private ICommand buttonY;

    public ICommand ProcessInput ()
    {
        if (Input.GetKeyDown("BUTTON_A")) return buttonA;
        if (Input.GetKeyDown("BUTTON_B")) return buttonB;
        if (Input.GetKeyDown("BUTTON_X")) return buttonX;
        if (Input.GetKeyDown("BUTTON_Y")) return buttonY;

        return null;
    }
}
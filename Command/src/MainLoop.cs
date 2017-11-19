InputManager inputManager = new Inputmanager ();
ICommand currentButton;
Player player1 = new Player ();

// Initializing Commands
void Awake ()
{
    inputManager.buttonA = new JumpCommand ();
    inputManager.buttonB = new SpecialAttackCommand ();
    inputManager.buttonX = new LightAttackCommand ();
    inputManager.buttonY = new HeavyAttackCommand ();
}

// Game Loop
void Update ()
{
    currentButton = inputManager.ProcessInput();
    if (currentButton != null)
        currentButton.execute(player1);
}
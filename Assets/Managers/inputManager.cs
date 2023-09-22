using UnityEngine;

public static class inputManager
{
    private static Controls _controls;
    public static void Init(player myPlayer)
    {
        _controls = new Controls();
        _controls.Game.Movement.performed += ctx => 
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };

        //Hp section
        _controls.Game.subHP.performed += ctx =>
        {
            myPlayer.SubHP(10);
            Debug.Log("SubHP pressed");
        };
        _controls.Game.addHP.performed += ctx =>
        {
            myPlayer.AddHP(10);
            Debug.Log("SubHP pressed");
        };

        _controls.Permanent.Enable();

    }
    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }
    public static void UImode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();
    }
}

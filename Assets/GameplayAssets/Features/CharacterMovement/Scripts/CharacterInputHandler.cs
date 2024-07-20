namespace HeatsGame.Features.CharacterMovement
{
    using UnityEngine;
    using UnityEngine.InputSystem;

    public class CharacterInputHandler
    {
        protected InputHandler input = null;

        protected CharacterInputHandler() 
        {
            input = new InputHandler();
            input.Enable();
        }

        protected virtual Vector3 GetMovingDirection() => input.MovmentDefault.Movement.ReadValue<Vector3>();

        protected virtual Vector2 GetRotatingDirection() => input.MovmentDefault.Mouse.ReadValue<Vector2>();
    }
}

namespace HeatsGame.Features.CharacterMovement
{
    using UnityEngine;

    /// <summary>
    /// Класс для обработки инпута
    /// </summary>
    public class CharacterInputHandler
    {
        protected InputHandler input = null;

        public CharacterInputHandler() 
        {
            input = new InputHandler();
            input.Enable();
        }

        /// <summary>
        /// Возвращает вектор от нажатия клавиш движения
        /// </summary>
        public virtual Vector3 GetMovingDirection() => input.MovmentDefault.Movement.ReadValue<Vector3>();

        /// <summary>
        /// Возвращает вектор поворота мыши
        /// </summary>
        public virtual Vector2 GetRotatingDirection() => input.MovmentDefault.Mouse.ReadValue<Vector2>();
    }
}

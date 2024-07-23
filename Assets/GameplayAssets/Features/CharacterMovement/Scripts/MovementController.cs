namespace HeatsGame.Features.CharacterMovement
{
    using UnityEngine;

    /// <summary>
    /// Реализует перемещение персонажа
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class MovementController : MonoBehaviour
    {
        [SerializeField] protected float speed = 0f;

        protected Vector3 movingDirection = Vector3.zero;
        
        protected CharacterInputHandler inputHandler = null;
        protected CharacterController characterController = null;  

        protected virtual void Awake()
        {
            inputHandler = new CharacterInputHandler();
            characterController = GetComponent<CharacterController>();
        }

        protected virtual void Update()
        {
            movingDirection = transform.TransformDirection(inputHandler.GetMovingDirection());

            characterController.Move(movingDirection * speed * Time.deltaTime);
        }
    }
}
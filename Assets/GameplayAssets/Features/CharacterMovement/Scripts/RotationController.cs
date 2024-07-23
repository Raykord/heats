namespace HeatsGame.Features.CharacterMovement
{
    using UnityEngine;

    public class RotationController : MonoBehaviour
    {
        [SerializeField] protected float turnSmoothTime = 0.1f;
        [SerializeField] private float turnSmoothVelocity = 0f;

        protected CharacterInputHandler inputHandler = null;
        protected Vector3 playerDirection = Vector3.zero;
        protected Transform cam;

        protected virtual void Awake()
        {
            inputHandler = new CharacterInputHandler();
            cam = Camera.main.transform;
        }

        protected virtual void Update()
        {
            playerDirection = inputHandler.GetMovingDirection();
            if (playerDirection.magnitude > 0.1f)
            {
                float targetAngle = Mathf.Atan2(playerDirection.x, playerDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }
            
        }
    }
}


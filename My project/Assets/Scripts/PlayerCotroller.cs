using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCotroller : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves
    public float jumpPower = 5f; // Force applied when the player jumps
    public float gravity = -9.81f; // Gravity applied to the player

    private float verticalVelocity; // Current velocity of the player

    private Vector2 moveInput;
    private CharacterController controller;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f; // Reset vertical velocity when grounded
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        move = move * moveSpeed;
        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);
    }


    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed && controller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }
}

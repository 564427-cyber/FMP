using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //camera

    public CharacterController controller;
    public Transform cam;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float smoothTurnVelocity;
    Vector3 direction;

    //jump

    float verticalVelocity;
    float gravity = -9.81f;
    float jumpForce = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    void Update()
    {
        
        DoMovement();
        
    }

    void DoMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontal, 0f, vertical).normalized;

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(jumpForce * -2f * gravity);
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = Vector3.zero;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurnVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            move = moveDir.normalized * speed;
        }

        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);
    }


}
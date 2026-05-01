using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //camera

    public CharacterController controller;
    public Transform cam;
    public float walkSpeed = 6f;
    public float runSpeed = 10f;
    public float turnSmoothTime = 0.1f;
    float smoothTurnVelocity;
    Vector3 direction;

    //jump

    float verticalVelocity;
    float gravity = -15f;
    float jumpForce = 1.7f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;
    bool runPressed;


    //Animation

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //read inputs
         runPressed = Input.GetKey(KeyCode.LeftShift);


        DoMovement();        
        DoAnimation();
    }

    void DoMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        float speed;
        direction = new Vector3(horizontal, 0f, vertical).normalized;

        //check for run
        if( runPressed == true)
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }


            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
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

    void DoAnimation()
    {
        
        bool jumpPressed = Input.GetKeyDown(KeyCode.Space) && isGrounded;
        bool jumpReset = Input.GetKeyUp(KeyCode.Space);

        bool isMoving = direction.magnitude > 0.1f;
        bool isRunning = isMoving && runPressed;

        if (isRunning) 
        {
            animator.SetBool("Run", true);
            animator.SetBool("Walk", false);

            Debug.Log("Is Running" + isRunning);
            
        }
        else if (isMoving)
        {
            animator.SetBool("Run", false);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Run", false);
            animator.SetBool("Walk", false);
        }

        if (jumpPressed)
        {
            Debug.Log("jumpTriggered");
            animator.SetBool("Jump", true);
        }
        if (jumpReset)
        {
            animator.SetBool("Jump", false);
        }
    }


}
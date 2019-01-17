using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private CharacterController _controller;
    private Animator _anim;
    public float speed;
    public float walkSpeed = 1.7f;
    public float runSpeed = 3.0f;
    public float reverseSpeed = 0.7f;
    public float rotateSpeed = 2.0f;


    public float jumpSpeed = 7.5f;
    public float gravity = 9.8f;


    private Vector3 moveDirection = Vector3.zero;
    private float turnDirection;
    // Start is called before the first frame update

    void Awake()
    {
        _anim = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();

        _controller.enabled = true;
        _controller.center = new Vector3(0, 1, 0);
    }

    void Start()
    {
        //Temp spawn point
        transform.position = new Vector3(-121.03f, 21.15f, 244f);

        speed = walkSpeed;
        _anim.SetFloat("Speed", speed);
        //_anim.SetBool("isWalking", false);
        _anim.SetBool("isCrouching", false);
        _anim.SetBool("isGrounded", true);

    }

    // Update is called once per frame
    void Update()
    {

        if (_controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(0, 0.0f, Input.GetAxis("Vertical"));
            turnDirection = Input.GetAxis("Horizontal");
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            //Not jumping
            _anim.SetBool("isGrounded", _controller.isGrounded);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        }

        _anim.SetBool("isGrounded", _controller.isGrounded);

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        if (Input.GetAxis("Vertical") > 0)
        {
            //Move forward at speed
            _controller.Move(moveDirection * speed * Time.deltaTime);
        }
        else
        {
            //Walk backward at reverse speed
            _controller.Move(moveDirection * reverseSpeed * Time.deltaTime);
        }
        _controller.transform.Rotate(0, turnDirection * rotateSpeed, 0);


    }
}

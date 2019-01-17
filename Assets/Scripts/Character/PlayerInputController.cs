using UnityEngine;
using Controllers.Movement;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField]
    CharacterController _controller;

    [SerializeField]
    float moveSpeed = 7f;

    [SerializeField]
    float turnSpeed = 50f;

    [SerializeField]
    float jumpSpeed = 7f;

    Vector3 movement = Vector3.zero;
    float turn;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();

    }

    void Update()
    {
        movement = new Vector3(0, 0, Input.GetAxis("Vertical"));
        movement.y -= (9.8f * Time.deltaTime);
        turn = Input.GetAxis("Horizontal");

        if (Input.GetButton("Jump"))
        {
            if (_controller.isGrounded)
            {
                //Only jump if already grounded
                movement.y = jumpSpeed;
            }
        }


        _controller.Move(transform.TransformDirection(movement) * Time.deltaTime * moveSpeed);
        _controller.transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);

    }
}

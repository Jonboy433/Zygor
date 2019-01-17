using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator _anim;

    void Awake()
    {
        _anim = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                //Dont allow crouch animation to be queued while walking forward/backward
            }
            else
            {
                _anim.SetBool("isCrouching", !(_anim.GetBool("isCrouching")));
            }

        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            //If currently crouching; stand up
            _anim.SetBool("isCrouching", false);


            _anim.SetBool("forwardMovement", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            _anim.SetBool("forwardMovement", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _anim.SetBool("turningLeft", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            _anim.SetBool("turningLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _anim.SetBool("isWalkingBackwards", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            _anim.SetBool("isWalkingBackwards", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _anim.SetBool("turningRight", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            _anim.SetBool("turningRight", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //speed = runSpeed;
            //_anim.SetFloat("Speed", speed);


        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //speed = walkSpeed;
            //_anim.SetFloat("Speed", speed);
        }
    }
}

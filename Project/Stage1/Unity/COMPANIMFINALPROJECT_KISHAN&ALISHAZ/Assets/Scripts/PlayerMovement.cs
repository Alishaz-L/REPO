using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    public float speed = 1.0f;
    public float jumpHeight = 1.0f;
    public float gravity = -9.81f;
    private Vector3 velocity; 
    private bool isGrounded;
    public Transform groundCheck;
    public float groundDistance=0.4f; 
    public LayerMask groundMask;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical"); 
        Vector3 move = transform.right * h + transform.forward * v;
        characterController.Move(move*speed*Time.deltaTime);
        animator.SetFloat("Speed", move.magnitude);
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            animator.SetTrigger("Jump"); 
        }
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }
        velocity.y += gravity * Time.deltaTime; 
        characterController.Move(velocity*Time.deltaTime);

    }

}

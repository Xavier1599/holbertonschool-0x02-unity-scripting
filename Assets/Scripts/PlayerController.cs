using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController control;
    private bool groundedPlayer;
    public Vector3 playerVelocity;
   public float speed = 0f;
   
    void Start()
    {
        control = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = control.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        control.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}

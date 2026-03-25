using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingSound : MonoBehaviour
{
    [SerializeField] AudioSource walkingSound;
    private Vector3 lastPosition;
    public float groundCheckDistance = 1.1f;
    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float movement = Vector3.Distance(transform.position,lastPosition);
        bool groundCheck= IsGrounded();
        if (movement > .01f && groundCheck)
        {
            if (!walkingSound.isPlaying)
                walkingSound.Play(); 
        }
        else
        {
            {
            if (walkingSound.isPlaying)
                walkingSound.Stop();
        }
        }
        lastPosition = transform.position;
    }  

    bool IsGrounded()
{
    return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);
}

}

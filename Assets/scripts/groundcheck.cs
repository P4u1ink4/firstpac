using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcheck : MonoBehaviour
{
    private bool IsGrounded;
    public bool GetGroundedCheck()
    {
        return IsGrounded;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ground") && !IsGrounded)
        {
            IsGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("ground") && IsGrounded)
        {
            IsGrounded = false;
        }
    }
}

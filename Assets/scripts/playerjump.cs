using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float jumpForce;
    [SerializeField] private groundcheck groundCheck;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.GetKeyDown("w") && groundCheck.GetGroundedCheck())
        {
            //jump
            //Debug.Log("Jump");
            rigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}

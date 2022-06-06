using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    private Rigidbody2D body;
    private bool grounded;
    public int PlayerHealth=3;
    private Vector3 StartPosition;
    
    public void Start()
    {
        StartPosition = gameObject.transform.position;
    }


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput*speed,body.velocity.y);
        
        if(Input.GetKeyDown("w") && grounded)
        {
            Jump();
        }
    }
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x,speed*jump);
        grounded=false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="ground")
        {
            grounded = true;
        }
    }
    public void PlayerDissapear()
    {
        gameObject.SetActive(false);
    }
    public void Begin()
    {
        gameObject.transform.position = StartPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    [SerializeField] private restart _restart;
    [SerializeField] private PlayerMovement player;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            _restart.ButtonAppear();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost1dissapear : MonoBehaviour
{
    [SerializeField] private heart3dissapear heart3;
    [SerializeField] private heart2dissapear heart2;
    [SerializeField] private heart1dissapear heart1;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private deadscript dead;
    [SerializeField] private camerascript camera;
    [SerializeField] private restart _restart;
    private Rigidbody2D body;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            player.PlayerHealth = player.PlayerHealth-1;
            Damage();
        }
    }
    public void Damage()
    {
        if(player.PlayerHealth==2)
        {
            heart3.heart3Dissapear();
            player.Begin();
        }
        else if(player.PlayerHealth==1)
        {
            heart2.heart2Dissapear();
            player.Begin();
        }
        else if(player.PlayerHealth==0)
        {
            _restart.ButtonAppear();
            player.PlayerDissapear();
            camera.CameraAppear();
            dead.DeadAppear();
        }
    }
}
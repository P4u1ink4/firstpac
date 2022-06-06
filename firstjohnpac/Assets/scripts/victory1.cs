using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory1 : MonoBehaviour
{
    [SerializeField] private victory vic;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private restart _restart;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            vic.VictoryAppear();
            gameObject.SetActive(false);
            _restart.ButtonAppear();
        }
    }
}

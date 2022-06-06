using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost1 : MonoBehaviour
{
    public float moveSpeed = 2f;
    private float count=0f;
    public float amount = 180f;

    private void Update()
    {
        if(count<amount)
        {
            transform.position += new Vector3(1*Time.deltaTime*moveSpeed,0,0);
            count=count+1;
        }
        else
        {
            transform.position += new Vector3(-1*Time.deltaTime*moveSpeed,0,0);
            count=count+1;
            if(count==2*amount)
            {
                count=0;
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed,0,0);
    }
}

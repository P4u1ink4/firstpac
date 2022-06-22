using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textdisappear : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            gameObject.SetActive(false);
        }
    }
}

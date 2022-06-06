using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart2dissapear : MonoBehaviour
{
    public void heart2Dissapear()
    {
        gameObject.SetActive(false);
    }
    public void heart2Appear()
    {
        gameObject.SetActive(true);
    }
}

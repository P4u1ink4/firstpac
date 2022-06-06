using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart1dissapear : MonoBehaviour
{
    public void heart1Dissapear()
    {
        gameObject.SetActive(false);
    }
    public void heart1Appear()
    {
        gameObject.SetActive(true);
    }
}

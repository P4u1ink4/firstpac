using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart3dissapear : MonoBehaviour
{
    public void heart3Dissapear()
    {
        gameObject.SetActive(false);
    }
    public void heart3Appear()
    {
        gameObject.SetActive(true);
    }
}

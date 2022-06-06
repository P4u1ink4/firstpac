using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    public void VictoryDisappear()
    { 
        gameObject.SetActive(false);
    }
    public void VictoryAppear()
    { 
        gameObject.SetActive(true);
    }
}

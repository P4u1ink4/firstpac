using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{
    public void FlagDisappear()
    { 
        gameObject.SetActive(false);
    }
    public void FlagAppear()
    { 
        gameObject.SetActive(true);
    }
}

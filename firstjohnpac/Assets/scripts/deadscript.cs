using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadscript : MonoBehaviour
{
    public void DeadDissapear()
    {
        gameObject.SetActive(false);
    }
    public void DeadAppear()
    {
        gameObject.SetActive(true);
    }
}

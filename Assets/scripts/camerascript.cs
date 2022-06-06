using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public void CameraDisappear()
    { 
        gameObject.SetActive(false);
    }
    public void CameraAppear()
    { 
        gameObject.SetActive(true);
    }
}

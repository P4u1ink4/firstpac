using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void ButtonDisappear()
    { 
        gameObject.SetActive(false);
    }
    public void ButtonAppear()
    { 
        gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneName:"Level1");
    }
}

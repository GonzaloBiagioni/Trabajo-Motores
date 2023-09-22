using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{

    void Start()
    {
        
    }
    public void scenechanger()
    {
        SceneManager.LoadScene(0);
    }

}

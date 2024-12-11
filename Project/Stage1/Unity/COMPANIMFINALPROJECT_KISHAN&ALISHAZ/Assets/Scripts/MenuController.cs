using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void LoadCutscene()
    {
        SceneManager.LoadScene(1);
    }
    public void gameplay()
    {
        SceneManager.LoadScene(2);  
    }
}
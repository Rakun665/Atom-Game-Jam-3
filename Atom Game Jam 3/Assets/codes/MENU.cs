using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    public  void Exit()
    {
        Application.Quit();
    }
}

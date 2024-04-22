using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("InGame");
    }

    public void GameOff()
    {
        Application.Quit();
    }
}

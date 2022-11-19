using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayHendler()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitHendler()
    {
        Application.Quit();
    }
}

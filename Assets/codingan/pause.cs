using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public bool IsPaused;
    public GameObject PauseMenu;

    void Update()
    {
        if (IsPaused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }
    public void Resume()
    {
        IsPaused = !IsPaused;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}

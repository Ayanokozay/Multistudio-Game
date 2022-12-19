using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause2 : MonoBehaviour
{
    public bool IsPaused;
    public GameObject pasmen;

    void Update()
    {
        if (IsPaused)
        {
            pasmen.SetActive(true);
            Time.timeScale = 0f;
        }else
        {
            pasmen.SetActive(false);
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
}

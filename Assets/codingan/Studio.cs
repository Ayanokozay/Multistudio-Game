using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Studio : MonoBehaviour
{
    public void main()
    {
        SceneManager.LoadScene("Studio");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PilihStudio()
    {
        SceneManager.LoadScene("PilihStudio");
    }
    public void StudioFoto()
    {
        SceneManager.LoadScene("StudioFoto");
    }
    public void StudioRec()
    {
        SceneManager.LoadScene("StudioRec");
    }
    public void StudioMusic()
    {
        SceneManager.LoadScene("StudioMusic");
    }
    public void PodcastStudio()
    {
        SceneManager.LoadScene("PodcastStudio");
    }
    public void Warnet()
    {
        SceneManager.LoadScene("Warnet");
    }
}
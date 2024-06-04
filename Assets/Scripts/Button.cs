using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Button : MonoBehaviour
{

    public void Playgame()
    {
        SceneManager.LoadScene("Menu 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public AudioClip clickSound;
    public AudioSource audioSource;

    public void OnButtonClick()
    {
        audioSource.PlayOneShot(clickSound);
    }

}

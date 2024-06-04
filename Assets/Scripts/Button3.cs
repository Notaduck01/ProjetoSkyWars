using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Button3 : MonoBehaviour
{

    public void Gameplay1game()
    {
        SceneManager.LoadScene("Gameplay 1");
    }

    public void Gameplay2game()
    {
        SceneManager.LoadScene("Gameplay 2");
    }

    public void Gameplay3game()
    {
        SceneManager.LoadScene("Gameplay 3");
    }

    public void Gameplay4game()
    {
        SceneManager.LoadScene("Gameplay 4");
    }

    public void Gameplay5game()
    {
        SceneManager.LoadScene("Gameplay 5");
    }

    public void Gameplay6game()
    {
        SceneManager.LoadScene("Gameplay 6");
    }

    public void Titlegame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void BackruleGame()
    {
        SceneManager.LoadScene("Menu 1");
    }

    public AudioClip clickSound;
    public AudioSource audioSource;

    public void OnButtonClick()
    {
        audioSource.PlayOneShot(clickSound);
    }

}

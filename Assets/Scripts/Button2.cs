using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Button2 : MonoBehaviour
{

    public void rulesgame()
    {
        SceneManager.LoadScene("Rules");
    }

    public void BackmenuGame()
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

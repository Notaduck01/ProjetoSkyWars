using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Button1 : MonoBehaviour
{

    public void Upgame()
    {
        SceneManager.LoadScene("Menu 2");
    }

    public void BackGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public AudioClip clickSound;
    public AudioSource audioSource;

    public void OnButtonClick()
    {
        audioSource.PlayOneShot(clickSound);
    }
    


}

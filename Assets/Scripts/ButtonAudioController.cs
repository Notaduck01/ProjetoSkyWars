using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudioController : MonoBehaviour
{
    public AudioClip clickSound;
    public AudioSource audioSource;

    public void OnResetClick()
    {
        audioSource.time = 0;
        audioSource.Play();
    }

    public void OnButtonClick()
    {
        AudioSource.PlayClipAtPoint(clickSound, transform.position);
    }

}

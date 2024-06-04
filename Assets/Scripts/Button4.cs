using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Button4 : MonoBehaviour
{
    public void BackPlayGame()
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

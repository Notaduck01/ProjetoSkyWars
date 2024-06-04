using Unity.VisualScripting;
using UnityEngine;

public class MusicLooper : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip music1;
    public AudioClip music2;

    public static MusicLooper instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);                
        }
    }

    private void Start()
    {
        audioSource.clip = music1;
        audioSource.Play();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = music2;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void OnRest()
    {
        audioSource.time = 0;
        audioSource.Play();
    }
}


using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip sfx;
    [SerializeField] private AudioClip anotherSFX;
    [SerializeField] private AudioClip bgm;


    public static AudioManager current;

    private AudioSource audioSource;


    private void Start()
    {
        current = this;
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}

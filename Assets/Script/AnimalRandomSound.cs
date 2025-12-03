using UnityEngine;
using System.Collections;

public class AnimalRandomSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clips;        // เสียงหลายแบบ
    public float minDelay = 3f;
    public float maxDelay = 8f;

    private void Start()
    {
        StartCoroutine(PlayRandomSounds());
    }

    private IEnumerator PlayRandomSounds()
    {
        while (true)
        {
            float waitTime = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(waitTime);

            if (clips.Length > 0)
            {
                AudioClip clip = clips[Random.Range(0, clips.Length)];
                audioSource.PlayOneShot(clip);
            }
        }
    }
}
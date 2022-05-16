using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioClip buttonSound;

    public void PlayButtonSound()
    {
        AudioSource sfx = GetComponent<AudioSource>();
        sfx.PlayOneShot(buttonSound);
    }
}

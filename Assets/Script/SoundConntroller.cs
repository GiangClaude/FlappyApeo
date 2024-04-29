using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    //Design pattern: Singleton
    public static SoundController instance;

    private void Awake()
    {
        instance = this;
    }
    public void PlayThisSound(string clipName, float volumeMultiplier)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        //Them component audiosource - audioClip = none
        //Co the truy cap audioClip ben ngoai
        audioSource.volume *= volumeMultiplier;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sound/" + clipName, typeof(AudioClip)));
        //PlayOneShot: Choi doc lap, khong bi xung dot giua cac am thanh

    }
}

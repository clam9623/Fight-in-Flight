using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void VolumeSetter (float volume)
    {
        audioMixer.SetFloat("BackgroundMusic", volume);
    }
}

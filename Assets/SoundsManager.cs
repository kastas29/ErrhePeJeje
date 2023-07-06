using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    // Do I need to add something like a queue of sounds?
    // I do not see the point of doing so, because I cannot imagine a situation where this could be needed. idk help me please

    public static SoundsManager Instance { get; private set; }

    [SerializeField] AudioSource aSource;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlaySound(AudioClip sound)
    {
        if(aSource.clip != null) aSource.Stop(); // Stop the clip if there is any playing atm
        aSource.clip = sound; // Change the clip to be played to the one in the parameters
        aSource.Play(); // Play the actual sound
    }

    public bool isSoundBeingPlayed()
    {
        return aSource.isPlaying; // Return if the current audio clip is being played rn
    }

    public void StopSoundPlaying()
    {
        aSource.Stop(); // Simply stop the sound if there is any being played
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource playerAudioSource;
    public AudioClip backgroundMusic, loseMusic, winMusic, buttonClick, enemySquishAlt, enemySquish, equipPowerUp, firingAlt, firing, snapClick, popAltOne, popAltTwo, pop, sneezeAlt, sneeze, vo1, vo2, vo3, vo4, vo5, vo6, vo7, vo8, vo9, vo10, vo11, vo12, vo13, vo141, vo142, vo151, vo152, vo161, vo162, vo171, vo172, vo18, vo19, vo20, vo21, vo22, vo23, vo24, vo25, vo26, vo27, vo28, vo29;
    
    public void PlayAudio(AudioClip audio, float volume)
    {
        playerAudioSource.PlayOneShot(audio, volume);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AgentStepAudio : MonoBehaviour
{
    protected AudioSource audioSource;

    [SerializeField]
    protected float pitchRandomness = 0.05f;
    protected float BasePitch;

    [SerializeField]
    protected AudioClip stepClip;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        BasePitch = audioSource.pitch;
    }

    protected void PlayClipWithRandomness(AudioClip clip)
    {
        var randomPitch = Random.Range(-pitchRandomness, pitchRandomness);
        audioSource.pitch = BasePitch + randomPitch;
        PlayClip(clip);
    }

    protected void PlayClip(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void PlayStepSound()
    {
        PlayClipWithRandomness(stepClip);
    }
}

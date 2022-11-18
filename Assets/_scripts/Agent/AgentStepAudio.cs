using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentStepAudio : AudioPlayer
{
    [SerializeField]
    protected AudioClip stepClip;

    //hvergang vore player stepper s� kommer der step-lyd
    public void PlayStepSound()
    {
        PlayClipWithRandomness(stepClip);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAudio : AudioPlayer
{
    [SerializeField]
    private AudioClip shootBulletClip = null, outOfBulletsClip = null;

    // hvergang man skyder s� kommer der lyd
    public void PlayShootSound()
    {
        PlayClip(shootBulletClip);
    }

    //hvis man l�ber t�r f�r bullet laver vore gun en lyd "no ammo"
    public void PlayNoBulletSound()
    {
        PlayClip(outOfBulletsClip);
    }

}

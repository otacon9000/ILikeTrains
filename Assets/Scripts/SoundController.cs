﻿using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
{

    public static SoundController instance;
    //ENVIRONMENT AUDIO
    public AudioClip[] environmentAudioClips = new AudioClip[2];

    //TRAPS AUDIO
    public AudioClip[] dynamiteAudioClips = new AudioClip[3];
    public AudioClip[] moonshineAudioClips = new AudioClip[3];

    //TRAIN AUDIO
    public AudioClip[] HQAudioClips = new AudioClip[3];

    //ENEMY AUDIO
    public AudioClip kamikazeAudioClip;
    public AudioClip[] horseIndianAudioClips = new AudioClip[3];
    public AudioClip[] armoredBanditAudioClips = new AudioClip[2];
    public AudioClip[] rifleBanditAudioClips = new AudioClip[2];
    public AudioClip[] indianLancerAudioClips = new AudioClip[2];
    public AudioClip[] berserkAudioClips = new AudioClip[3];












    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    void Start()
    {

    }



}

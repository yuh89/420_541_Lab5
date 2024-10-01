using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayPunchSound()
    {
        audioSource.Play();
    }
}

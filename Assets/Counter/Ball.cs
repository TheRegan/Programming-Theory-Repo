using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Ball : CatchableObject
{
    [SerializeField] private AudioSource thisAudioSource;
    [SerializeField] private AudioClip[] clips;
    [SerializeField] private AudioClip clip;
    

    private void Awake()
    {
        thisAudioSource = GetComponent<AudioSource>();
        clip = getRandomAudioClipfromArray(clips);
        thisAudioSource.clip = clip;
    }

    //POLYMORPHISM
    public override void CaughtObject()
    {
        GetComponent<MeshRenderer>().enabled = false;
        StartCoroutine(playAudio());
    }

    private IEnumerator playAudio()
    {
        thisAudioSource.Play();
        while (thisAudioSource.isPlaying)
            yield return null;
        base.CaughtObject();
    }

    private AudioClip getRandomAudioClipfromArray(AudioClip[] clipsToChooseFrom)
    {
        return clipsToChooseFrom[Random.Range(0,clipsToChooseFrom.Length)];
    }
}

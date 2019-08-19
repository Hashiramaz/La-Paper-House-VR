using UnityEngine.Audio;
using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour {


    public Sound[] sounds;
	// Use this for initialization
	void Awake () {
		foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
	}

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();

        Debug.Log("Tocando Audio " + name);
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }

    private void Start()
    {
        Play("MainMusic");
        Play("WindMusic");
    }

    // Update is called once per frame
    void Update () {
		
	}

        public  IEnumerator FadeOutStop(string name, float FadeTime, float volumelimit) {
        
        Sound s = Array.Find(sounds, sound => sound.name == name);
       
        float startVolume = s.source.volume;


        yield return null;
        while (s.source.volume > volumelimit) {
            s.source.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        s.source.Stop();
    }
    public  IEnumerator FadeInPlay(string audioSourceName, float FadeTime, float volumelimit) {

        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        
        s.source.volume = 0f;
        while (s.source.volume < volumelimit) {
            s.source.volume += Time.deltaTime / FadeTime;
            yield return null;
        }
    }

    public void StartLowerVolume(string name){
        StartCoroutine(LowerVolume(name,0.5f,0.2f) );
    }
    public  IEnumerator LowerVolume(string name, float FadeTime, float volumelimit) {
        Debug.Log("Lower Volume");
        Sound s = Array.Find(sounds, sound => sound.name == name);
       
        float startVolume = s.source.volume;


        yield return null;
        while (s.source.volume > volumelimit) {
            s.source.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        

    }

public void StartHigherVolume(string name){
    StartCoroutine(HigherVolume(name,0.5f,1f));
}
    
    public  IEnumerator HigherVolume(string audioSourceName, float FadeTime, float volumelimit) {
        Debug.Log("Higher Volume");
        Sound s = Array.Find(sounds, sound => sound.name == name);
       
        
        s.source.volume = 0f;
        while (s.source.volume < volumelimit) {
            s.source.volume += Time.deltaTime / FadeTime;
            yield return null;
        }
    }


    
}

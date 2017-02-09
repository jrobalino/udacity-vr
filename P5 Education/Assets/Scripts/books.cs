using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class books : MonoBehaviour {

    public GameObject growObject;
    public GameObject growObject2;
    public float growthFactor = .005f;
    public AudioSource hover;
    public AudioSource changeScenes;


	// Use this for initialization
	void Start () {
        ParticleSystem ps = growObject.GetComponentInChildren<ParticleSystem>();
        ps.Stop();//Start without emitting particles
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void switchScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void growBook()
    {
        //growObject.transform.localScale += new Vector3(growthFactor, growthFactor, growthFactor);
        //growObject2.transform.localScale += new Vector3(growthFactor, growthFactor, growthFactor);
        ParticleSystem ps = growObject.GetComponentInChildren<ParticleSystem>();
        ps.Play();//Start emitting particles
        hover.Play();
    }

    public void shrinkBook()
    {
        //growObject.transform.localScale -= new Vector3(growthFactor, growthFactor, growthFactor);
        //growObject2.transform.localScale -= new Vector3(growthFactor, growthFactor, growthFactor);
        ParticleSystem ps = growObject.GetComponentInChildren<ParticleSystem>();
        ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);//Stop emitting particles
    }
}

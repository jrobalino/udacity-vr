using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class presentation : MonoBehaviour {

    public AudioSource introAudio;
    public AudioSource sceneAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void switchScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void playAudio ()
    {
        introAudio.Stop();
        sceneAudio.Play();
    }
}

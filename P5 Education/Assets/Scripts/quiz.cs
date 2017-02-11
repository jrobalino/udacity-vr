using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour {

    public AudioSource introAudio;
    public AudioSource wrongAudio;
    public AudioSource correctAudio;
    public GameObject wrongAnswers;
    public GameObject panel;
    public Button correctButton;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void wrongAnswer()
    {
        introAudio.Stop();
        wrongAudio.Play();

    }

    public void correctAnswer()
    {
        Image successPanel;

        correctButton.enabled = false;

        introAudio.Stop();
        correctAudio.Play();

        wrongAnswers.SetActive(false);
        successPanel = panel.GetComponent<Image>();
        successPanel.color = new Color(.984f, 1f, .839f);

    }
}

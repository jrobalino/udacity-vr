using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    private int currentScore;
    public AudioSource winAudio;
    
    // Use this for initialization
	void Start () {
        currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void increaseScore()
    {
        currentScore ++;
        checkScore();
    }

    public void playWinAudio()
    {
        winAudio.Play();
    }

    public void checkScore()
    {
        if (currentScore == 5)
        {
            Invoke("playWinAudio", 3f);

        }
    }
}

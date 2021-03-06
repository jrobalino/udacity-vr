﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public GameObject player;
    public GameObject eventSystem;
    public GameObject startUI, restartUI;
    public GameObject growObject, growObject2;
    public GameObject startPoint, playPoint, restartPoint;
    public Text scoreText, lengthText, speedText;
    public GameObject[] puzzleSpheres; //An array to hold our puzzle spheres

    public int puzzleLength = 5; //How many times we light up.  This is the difficulty factor.  The longer it is the more you have to memorize in-game.
    public float puzzleSpeed = 1;
    private int puzzleSpeedValue = 1; //How many seconds between puzzle display pulses
    private int[] puzzleOrder; //For now let's have 5 orbs

    private int currentDisplayIndex = 0; //Temporary variable for storing the index when displaying the pattern
    public bool currentlyDisplayingPattern = true;
    public bool playerWon = false;
    public GameObject failAudioHolder;

    private int currentSolveIndex = 0; //Temporary variable for storing the index that the player is solving for in the pattern.
    private int failCount = 0; // The number of times the player failed before getting the pattern correct.
    private Text scoreMessage, lengthMessage, speedMessage;


    // Use this for initialization
    void Start () {
        player.transform.position = startPoint.transform.position;
        puzzleOrder = new int[puzzleLength]; //Set the size of our array to the declared puzzle length
        generatePuzzleSequence(); //Generate the puzzle sequence for this playthrough.
        lengthMessage = lengthText.GetComponent<Text>();
        lengthMessage.text = "" + puzzleLength;
        speedMessage = speedText.GetComponent<Text>();
        switch (puzzleSpeedValue)
        {
            case 0:
                puzzleSpeed = 2f;
                speedMessage.text = "Easy";
                break;
            case 1:
                puzzleSpeed = 1f;
                speedMessage.text = "Normal";
                break;
            case 2:
                puzzleSpeed = .5f;
                speedMessage.text = "Hard";
                break;
            case 3:
                puzzleSpeed = .25f;
                speedMessage.text = "Insane";
                break;
        }
        
    }

	// Update is called once per frame
	void Update () {
        
    }

    public void increaseLength()
    {
        // Controls the setting for increasing the puzzle length
        puzzleLength++;
        lengthMessage.text = "" + puzzleLength;
    }

    public void decreaseLength()
    {
        // Controls the setting for decreasing the puzzle length
        if (puzzleLength >= 4)
        {
            puzzleLength--;
        }
        
        lengthMessage.text = "" + puzzleLength;
    }

    public void increaseSpeed()
    {
        // Controls the setting for increasing the puzzle speed
        if (puzzleSpeedValue <= 2)
        {
            puzzleSpeedValue++;
        }

        // Displays the difficulty of the game depending on the speed selected
        switch (puzzleSpeedValue)
        {
            case 0:
                puzzleSpeed = 2f;
                speedMessage.text = "Easy";
                break;
            case 1:
                puzzleSpeed = 1f;
                speedMessage.text = "Normal";
                break;
            case 2:
                puzzleSpeed = .5f;
                speedMessage.text = "Hard";
                break;
            case 3:
                puzzleSpeed = .25f;
                speedMessage.text = "Insane";
                break;
        }

        
        
    }

    public void decreaseSpeed()
    {
        // Controls the setting for decreasing the speed of the game
        if (puzzleSpeedValue >= 1)
        {
            puzzleSpeedValue--;
        }

        // Displays the difficulty of the game depending on the speed selected
        switch (puzzleSpeedValue)
        {
            case 0:
                puzzleSpeed = 2f;
                speedMessage.text = "Easy";
                break;
            case 1:
                puzzleSpeed = 1f;
                speedMessage.text = "Normal";
                break;
            case 2:
                puzzleSpeed = .5f;
                speedMessage.text = "Hard";
                break;
            case 3:
                puzzleSpeed = .25f;
                speedMessage.text = "Insane";
                break;
        }
    }

    public void toggleUI() {
		startUI.SetActive (!startUI.activeSelf);
		restartUI.SetActive (!restartUI.activeSelf);
	}

    public void growText()
    {
        growObject.transform.localScale += new Vector3(.15f, .15f, .15f);
        growObject2.transform.localScale += new Vector3(.15f, .15f, .15f);
    }

    public void shrinkText()
    {
        growObject.transform.localScale -= new Vector3(.15f, .15f, .15f);
        growObject2.transform.localScale -= new Vector3(.15f, .15f, .15f);
    }

    public void startPuzzle()
    { //Begin the puzzle sequence
      //Generate a random number one through five, save it in an array.  Do this n times.
      //Step through the array for displaying the puzzle, and checking puzzle failure or success.
        //startUI.SetActive(false);
        eventSystem.SetActive(false);
 
        
        
        iTween.MoveTo(player,
        iTween.Hash(
            "position", playPoint.transform.position,
            "time", 7,
            "easetype", "linear",
            "oncomplete", "displayPatternPrep",
            "oncompletetarget", this.gameObject
        )
    );
        

    }

    public void displayPatternPrep()
    {
        CancelInvoke("displayPattern");
        InvokeRepeating("displayPattern", 3, puzzleSpeed); //Start running through the displaypattern function
        currentSolveIndex = 0; //Set our puzzle index at 0
    }

    public void resetPuzzle()
    { //Reset the puzzle sequence
        iTween.MoveTo(player,
            iTween.Hash(
                "position", startPoint.transform.position,
                "time", 0,
                "easetype", "linear",
                "oncomplete", "resetGame",
                "oncompletetarget", this.gameObject
            )
        );

        //restartUI.SetActive(false);
    }

    public void playerSelection(GameObject sphere)
    {
        if (playerWon != true)
        { //If the player hasn't won yet
            int selectedIndex = 0;
            //Get the index of the selected object
            for (int i = 0; i < puzzleSpheres.Length; i++)
            { //Go through the puzzlespheres array
                if (puzzleSpheres[i] == sphere)
                { //If the object we have matches this index, we're good
                    //Debug.Log("Looks like we hit sphere: " + i);
                    selectedIndex = i;
                }
            }
            solutionCheck(selectedIndex);//Check if it's correct
        }
    }

    public void solutionCheck(int playerSelectionIndex)
    { //We check whether or not the passed index matches the solution index
        if (playerSelectionIndex == puzzleOrder[currentSolveIndex])
        { //Check if the index of the object the player passed is the same as the current solve index in our solution array
            currentSolveIndex++;
            //Debug.Log("Correct!  You've solved " + currentSolveIndex + " out of " + puzzleLength);
            if (currentSolveIndex >= puzzleLength)
            {
                puzzleSuccess();
            }
        }
        else
        {
            puzzleFailure();
        }

    }

    void displayPattern()
    { //Invoked repeating.
        currentlyDisplayingPattern = true; //Let us know we are displaying the pattern
        eventSystem.SetActive(false); //Disable gaze input events while we are displaying the pattern.
       
        if (currentlyDisplayingPattern == true)
        { //If we are not finished displaying the pattern
            if (currentDisplayIndex < puzzleOrder.Length)
            { //If we haven't reached the end of the puzzle
                //Debug.Log(puzzleOrder[currentDisplayIndex] + " at index: " + currentDisplayIndex);
                puzzleSpheres[puzzleOrder[currentDisplayIndex]].GetComponent<lightUp>().patternLightUp(puzzleSpeed); //Light up the sphere at the proper index.  For now we keep it lit up the same amount of time as our interval, but could adjust this to be less.
                currentDisplayIndex++; //Move one further up.
            }
            else
            {
                //Debug.Log("End of puzzle display");
                failCount++; // Increase the number of attempts it is taking the user to solve the puzzle
                currentlyDisplayingPattern = false; //Let us know were done displaying the pattern
                currentDisplayIndex = 0;
                CancelInvoke(); //Stop the pattern display.  May be better to use coroutines for this but oh well
                eventSystem.SetActive(true); //Enable gaze input when we aren't displaying the pattern.
            }
        }
    }


    public void generatePuzzleSequence()
    {
        
        int tempReference;
        for (int i = 0; i < puzzleLength; i++)
        { //Do this as many times as necessary for puzzle length
            tempReference = Random.Range(0, puzzleSpheres.Length); //Generate a random reference number for our puzzle spheres
            puzzleOrder[i] = tempReference; //Set the current index to our randomly generated reference number
        }
    }

    public void resetGame()
    {
        //restartUI.SetActive(false);
        //startUI.SetActive(true);
        playerWon = false;
        puzzleOrder = new int[puzzleLength];
        generatePuzzleSequence(); //Generate the puzzle sequence for this playthrough.  
        failCount = 0;
    }

    public void puzzleFailure()
    { //Do this when the player gets it wrong
        //Debug.Log("You've Failed, Resetting puzzle");
        failAudioHolder.GetComponent<GvrAudioSource>().Play();
        currentSolveIndex = 0;
        startPuzzle();

    }

    public void puzzleSuccess()
    { //Do this when the player gets it right
        this.GetComponent<AudioSource>().Play(); //Play the success audio
        // Display how many attempts it took the user to succeed
        scoreMessage = scoreText.GetComponent<Text>();
        if (failCount == 1)
        {
            scoreMessage.text = "You won on your first attempt!";
        }
        else
        {
            scoreMessage.text = "You won after " + failCount + " attempts!";
        }
        
        iTween.MoveTo(player,
            iTween.Hash(
                "position", restartPoint.transform.position,
                "time", 7,
                "easetype", "linear",
                "oncomplete", "finishingFlourish",
                "oncompletetarget", this.gameObject
            )
        );
    }

    public void finishingFlourish()
    { //A nice visual flourish when the player wins
      
        //restartUI.SetActive(true);
        playerWon = true;

    }

}

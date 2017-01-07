using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{
    public Door door;
    public int numCoins = 7;
    static int coins = 0;
    static float apperception = 0;
    static bool displayText = false;
    Text message;

    public void Start()
    {
        // Set variables to their start values
        coins = 0;
        apperception = 0;
        displayText = false;
    }

    public void Update()
    {
        // if conditions are met, display the end score
        if (displayText == true)
        {
            message = GetComponent<Text>();
            message.text = "Coins collected: " + coins + " out of " + numCoins + "\nApperception level: " + apperception + "\n\nPlay again?";
        }
    }

    public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
        door.ResetVariables();
        SceneManager.LoadScene("Maze");
	}

    public void addCoin()
    {
        // Keep track of coins collected and calculate apperception score
        coins++;
        float coinsFloat = coins * 1.0f;
        float numCoinsFloat = numCoins * 1.0f;
        apperception = Mathf.Round(coinsFloat / numCoinsFloat * 20.0f);
    }

    public void drawText()
    {
        // Set this to true when the user opens the door
        displayText = true;
    }


}
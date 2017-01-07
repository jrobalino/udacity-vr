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
    Text message;

    public void Start()
    {
        coins = 0;
        apperception = 0;
    }

    public void Update()
    {
        message = GetComponent<Text>();
        message.text = "Coins collected: " + coins + " out of " + numCoins + "\nApperception level: " + apperception + "\n\nPlay again?";
    }

    public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
        door.ResetVariables();
        SceneManager.LoadScene("Maze");
	}

    public void addCoin()
    {
        coins++;
        float coinsFloat = coins * 1.0f;
        float numCoinsFloat = numCoins * 1.0f;
        apperception = Mathf.Round(coinsFloat / numCoinsFloat * 20.0f);
    }
}
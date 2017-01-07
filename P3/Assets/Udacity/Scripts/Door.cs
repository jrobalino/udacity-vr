using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    
    public static bool keyFound = false;
    public static bool doorClicked = false;
    public float speed = 0.5f;
    public AudioSource doorOpen;
    public AudioSource doorLocked;
    public SignPost signPost;

    public void Unlock()
    {
        keyFound = true;
        
    }

    public void OnDoorClicked()
    {
        // When the door is clicked, play appropriate audio and call doorOpen if player has key
        if (keyFound == true)
        {
            doorClicked = true;
            doorOpen.Play();
        }
        else
        {
            doorLocked.Play();
        }

    }

    public void Update()
    {
        // If the key has been found and the door is clicked, move it up
        if (keyFound == true && doorClicked == true)
        {
            
            Vector3 endPosition = new Vector3(transform.position.x, 9.0f, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, endPosition, speed * Time.deltaTime);
            signPost.drawText();
            
        }
    }

    public void ResetVariables()
    {
        // Reset variables when scene restarts
        keyFound = false;
        doorClicked = false;
    }
}

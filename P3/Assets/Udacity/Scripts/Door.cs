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

    public void Unlock()
    {
        keyFound = true;
        
    }

    public void OnDoorClicked()
    {
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
        if (keyFound == true && doorClicked == true)
        {
            
            Vector3 endPosition = new Vector3(transform.position.x, 9.0f, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, endPosition, speed * Time.deltaTime);
            
        }
    }

    public void ResetVariables()
    {
        keyFound = false;
        doorClicked = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoofPrefab;
    public Door door;
    public float rotateSpeed = 200f;
    public AudioSource keyChime;
    public static bool destroy;

    private void Start()
    {
        destroy = false;
    }

    void Update()
	{
        //Bonus: Key Animation
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        transform.position = transform.position + new Vector3(0.05f * Mathf.Sin(Time.time), 0, 0);

        // Destroy the key if conditions are met and display poof for longer than coins
        if (destroy == true)
        {
            Vector3 keyPos = transform.position;
            
            Destroy(transform.gameObject, 2);
            // Instantiate the KeyPoof Prefab where this key is located
            Instantiate(keyPoofPrefab, keyPos, Quaternion.identity);
        }
	}

	public void OnKeyClicked()
	{

        // Play key chime
        keyChime.Play();

        // Call the Unlock() method on the Door
        door.Unlock();

        // Set bool to true to destroy the key
        destroy = true;
    }

}

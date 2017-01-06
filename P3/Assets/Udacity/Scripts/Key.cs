using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoofPrefab;
    public Door door;
    public float rotateSpeed = 200f;
    

	void Update()
	{
        //Bonus: Key Animation
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        transform.position = transform.position + new Vector3(0.05f * Mathf.Sin(Time.time), 0, 0);
	}

	public void OnKeyClicked()
	{
        Vector3 keyPos = transform.position;

        // Destroy this coin
        Destroy(transform.gameObject);

        // Instantiate the KeyPoof Prefab where this key is located
        Instantiate(keyPoofPrefab, keyPos, Quaternion.identity);

        // Call the Unlock() method on the Door
        door.Unlock();
    }

}

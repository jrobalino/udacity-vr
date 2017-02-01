using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class books : MonoBehaviour {

    public GameObject growObject;
    public GameObject growObject2;
    public float growthFactor = .005f;


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

    public void growBook()
    {
        growObject.transform.localScale += new Vector3(growthFactor, growthFactor, growthFactor);
        growObject2.transform.localScale += new Vector3(growthFactor, growthFactor, growthFactor);
    }

    public void shrinkBook()
    {
        growObject.transform.localScale -= new Vector3(growthFactor, growthFactor, growthFactor);
        growObject2.transform.localScale -= new Vector3(growthFactor, growthFactor, growthFactor);
    }
}

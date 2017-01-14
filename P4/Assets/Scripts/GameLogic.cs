using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject player;
	public GameObject startUI, restartUI;
    public GameObject growObject;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void toggleUI() {
		startUI.SetActive (!startUI.activeSelf);
		restartUI.SetActive (!restartUI.activeSelf);
	}

    public void growText()
    {
        growObject.transform.localScale += new Vector3(.15f, .15f, .15f);
    }

    public void shrinkText()
    {
        growObject.transform.localScale -= new Vector3(.15f, .15f, .15f);
    }
}

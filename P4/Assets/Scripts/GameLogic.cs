using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject player;
	public GameObject startUI, restartUI;
    public GameObject growObject, growObject2;
    public GameObject startPoint, playPoint, restartPoint;


    // Use this for initialization
    void Start () {
        player.transform.position = startPoint.transform.position;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && player.transform.position == playPoint.transform.position)
        {
            puzzleSuccess();
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
        //toggleUI();
        iTween.MoveTo(player,
            iTween.Hash(
                "position", playPoint.transform.position,
                "time", 7,
                "easetype", "linear"
            )
        );

    }

    public void resetPuzzle()
    { //Reset the puzzle sequence
        player.transform.position = startPoint.transform.position;
        //toggleUI();
    }


    public void puzzleSuccess()
    { //Do this when the player gets it right
        iTween.MoveTo(player,
            iTween.Hash(
                "position", restartPoint.transform.position,
                "time", 7,
                "easetype", "linear"
            )
        );
    }
    
}

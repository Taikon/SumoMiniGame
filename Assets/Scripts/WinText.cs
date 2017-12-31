using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinText : MonoBehaviour {

    private bool playerWin1;
    private GameObject playerObject;
    private PlayerController playerPlayerController;
    private float timer;
    private Text winText;

    // Use this for initialization
    void Start () {
        timer = 0.0f;
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerPlayerController = playerObject.GetComponent<PlayerController>();
        winText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        timer += Time.deltaTime;
        if (timer >= 15.0f)
        {
            playerWin1 = playerPlayerController.playerWin;
            if (playerWin1==true)
            {
                winText.text = "Winner!";
            }
            else
            {
                winText.text = "You lost!";
            }
        }
        else
        {
            winText.text = "";
        }
	}
}

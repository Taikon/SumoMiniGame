using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

    Text startText;
    float timerShow;

	// Use this for initialization
	void Start () {
        startText = GetComponent<Text>();
        timerShow = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timerShow += Time.deltaTime;

        if (timerShow <= 2.0f)
        {
            startText.text = "Start Game!";
        }
        else if (timerShow >= 12.0f)
        {
            startText.text = "Game Finish!";
        }
        else
        {
            startText.text = "";
        }
	}
}


/*
 *     textEnd(3.5f, timerShow, "Finish!");
 *     
 *     void textStart(float startTime, float timer, string startEndString)
    {
        if (timer <= startTime)
        {
            startText.text = startEndString;
        }
        else
        {
            startText.text = "";
        }
    }

    void textEnd(float endTime, float timer, string startEndString)
    {
        if (timer >= endTime)
        {
            startText.text = startEndString;
        }
        else
        {
            startText.text = "";
        }
    }
 */

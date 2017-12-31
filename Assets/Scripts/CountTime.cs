using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountTime : MonoBehaviour {

    Text countText;
    float timer;
    float countTimer;

	// Use this for initialization
	void Start () {
        countText = GetComponent<Text>();
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer += Time.deltaTime;
        countTimer = 12.0f - Mathf.Round(timer);
        if (timer <= 12.0f && timer >=2.0f)
        {
            countText.text = "Timer: " + countTimer;
        }
        else
        {
            countText.text = "";
        }
    }
}

/*
 *      textTime(1.0f, 2.0f, timerShow);
        textTime(2.0f, 3.0f, timerShow);

        void textTime(float start, float end, float timer)
    {
        if (timer >= start && timer < end)
        {
            int endInt = (int)end;
            startText.text = endInt.ToString();
        }
    }
 */

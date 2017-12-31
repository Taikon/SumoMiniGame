using UnityEngine;
using System.Collections;

public class SumoController : MonoBehaviour {

    public float speed;
    public float count;

    private bool playerWin0;
    private float timer;
    private GameObject playerObject;
    private PlayerController playerPlayerController;
    private Rigidbody rb; 
    //Note that the reason you don't need to anim=GetComponent<Animator>(); is because you are making EnemySumo share the exact SAME ANIMATIONS at the SAME TIME as the Player, just backwards. The player animator already has booleans to set when to start and end each animation, so no need to worry about it for EnemySumo.

    void Awake () {
        count = Random.Range(40.0f, 70.0f);
        timer = 0.0f;
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerPlayerController = playerObject.GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>();
    }
	
	void FixedUpdate () {
        timer += Time.deltaTime;
        if (timer > 12 && count != 0)
        {
            playerWin0 = playerPlayerController.playerWin;
            if (!playerWin0)
            {
                rb.AddForce(-count * speed, 0, 0, ForceMode.Impulse); //add force equal to count*speed (public) translated by x axis with an impulse to initiate movement.
            }
        }
    }
}

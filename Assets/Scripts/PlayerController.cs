using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public bool playerWin;

    private float count;
    private Rigidbody rb;
    private float timer;
    private Animator anim;
    private GameObject enemyObject;
    private SumoController enemySumoController;
    private float enemyCount;

	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        timer = 0.0f;
        count = 0.0f;
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        enemySumoController = enemyObject.GetComponent<SumoController>();
        enemyCount = enemySumoController.count;
	}
	
	void FixedUpdate () {
        timer += Time.deltaTime; //timer increases with time
        if (timer<=12 && timer>=2) //if timer <12 and >2 seconds
        {
            Charging(); //execute charging function
            if (Input.GetButtonDown("Fire1")) //if you press anyBUTTON (NOT ANY KEY BECAUSE BUTTON IS DEFINED, KEY IS UNDEFINED!)
            {
                count += 1f; //count will increase by 1
            }
        }
        else if (timer >12) {
            Attack(); //executes attack function
            Battle();
            if (playerWin == true)
            {
                rb.AddForce(count * speed, 0, 0, ForceMode.Impulse); //add force equal to count*speed (public) translated by x axis with an impulse to initiate movement.
            }
        }
    }

    void Attack()
    {
        anim.SetBool("isAttacking", true);//initiates trigger isAttacking
        anim.SetBool("isCharging", false);
    }

    void Charging()
    {
        anim.SetBool("isCharging", true); //initiates trigger isCharging
    }

    void Battle()
    {
        if (enemyCount >= count)
        {
            playerWin = false;
        }
        else if (count > enemyCount)
        {
            playerWin = true;
        }
    }
}

/* 2 gameobjects they collide and which ever one has higher speed wins. 
 * Interact with it by clicking buttons really fast, to increase speed.
 * 
 * 
 * beginning
 * animation
 * in 3 seconds, transition animation and count clicks
 * colliders must go forward after input is finished
 * compare count clicks
 * winner animation
 * loser animation
 * 
 * Game start: Text>welcome/instructions>countdown
 * PlayerController: Timer<3 seconds && Player input: transform limited to x axis. Call Input.Fire1, coun+=1. 
 *                   Move() PhysicsAnimation: transform.forward, transform.position+Vector3 (x,0,0). The Vector3 = count
 *                   Animate()
 * UI: Displays winner animation/loser animation
 * 
 * 
 * 
 * PlayerController
 * timer, 
 */ 
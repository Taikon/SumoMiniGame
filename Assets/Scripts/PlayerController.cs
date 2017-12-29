using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    private float timer;
    private float count;


	void Start () {
        rb = GetComponent<Rigidbody>();
        timer = 0f;
        count = 0;
	}
	
	void Update () {
        timer += Time.deltaTime; //timer increases with time
        if (timer<3) //if timer is <3sec
        {
            if (Input.GetButtonDown("Fire1")) //if you press anyBUTTON (NOT ANY KEY BECAUSE BUTTON IS DEFINED, KEY IS UNDEFINED!)
            {
                count += 1f; //count will increase by 1
            }
        }
        else { //if timer is not <3sec
            rb.AddForce(count * speed, 0, 0, ForceMode.Impulse); //add force equal to count*speed (public) translated by x axis with an impulse to initiate movement.
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            rb.velocity = new Vector3 (0, 0, 0);
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
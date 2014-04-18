using UnityEngine;
using System.Collections;
[RequireComponent(typeof(PlayerPhysics))]
public class PlayerController : MonoBehaviour {

	public float speed = 8;
	public float acceleration=12; 
	public float gravity = 20;
	private float currentSpeed;
	private float targetSpeed;
	private Vector2 amountToMove;

	private PlayerPhysics playerPhysics;
	// Use this for initialization
	void Start () {
		playerPhysics = GetComponent<PlayerPhysics> ();
	}
	
	// Update is called once per frame
	void Update () {
		targetSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		currentSpeed = IncrementTowards (currentSpeed, targetSpeed, acceleration);
		amountToMove.y -= gravity * Time.deltaTime;
		amountToMove.x = currentSpeed;
		playerPhysics.Move (amountToMove * Time.deltaTime);
	}

	private float IncrementTowards(float currSpeed, float target, float acceleration){
		if (currSpeed == target) {
				return currSpeed;
		}
		else { 
				float dir = Mathf.Sign (target - currSpeed);
				currSpeed += acceleration * Time.deltaTime * dir;
				return (dir == Mathf.Sign (target - currSpeed)) ? currSpeed : target; // if n 
				}
		}
}

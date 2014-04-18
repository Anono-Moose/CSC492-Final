using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {
	private BoxCollider collider;
	private Vector3 size;
	private Vector3 center;
	// Use this for initialization

	void Start(){
		collider = GetComponent<BoxCollider> ();
		size = collider.size;
		center = collider.center;

		}
	public void Move(Vector2 moveAmount){

		float deltaY = moveAmount.y;
		Vector2 p = transform.position;

		transform.Translate (moveAmount);
		}


}

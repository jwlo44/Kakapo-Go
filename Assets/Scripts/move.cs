using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public Rigidbody2D r;
	public int speed;
	public int jumpForce;
	private Vector2 horiForce = new Vector2(1, 0);
	private Vector2 vertForce = new Vector2(0, 1);
	private bool isJumping = false;
	public float maxHoriVelocity = 10;
	public float maxVertVelocity = 12;
	private int jumps = 5;
	private int maxJumps = 5;
	private float torque = 0f;


	public int getMaxJumps() {
		return maxJumps;
	}

	public void incrementJumps() {
		jumps++;
	}

	public int getJumps() {
		return jumps;
	}

	void MoveLeftOrRight() {
		if (Input.GetAxis ("Horizontal") > 0) {
			r.AddForce(horiForce * speed);
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			r.AddForce(-speed * horiForce);		
		}

		ClampVelocity ();
	}

	void ClampVelocity(){
		if (Mathf.Abs (r.velocity.x) > maxHoriVelocity) {
			float x = Mathf.Sign (r.velocity.x) * maxHoriVelocity;
			float y = r.velocity.y;
			r.velocity = new Vector2 (x, y);
		}
		if (Mathf.Abs (r.velocity.y) > maxVertVelocity) {
			float x = r.velocity.x;
			float y = Mathf.Sign (r.velocity.y) * maxVertVelocity;
			r.velocity = new Vector2 (x, y);
		}
	}

	void HandleJumping() {
		if (Input.GetAxis ("Jump") > 0) {
			if (!isJumping && jumps > 0) {
				if (isInAir()) {
					r.AddTorque(torque);
					//Debug.Log("Torquin it!");
				}
				r.velocity = new Vector2 (r.velocity.x, 0);
				isJumping = true;
				jumps--;
				Debug.Log ("Jumping! I have " + jumps + " jumps left!");
				r.AddForce (vertForce * jumpForce);
				EventManager.Instance.RaiseJumpEvent(this);
			}
		} else {
			isJumping = false;
		}
	}

	// Use this for initialization
	void Start () {
		if (globals.inCrazyMode) {
			torque = 500;
			maxJumps = 10000;
		} else {
			torque = 0;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		MoveLeftOrRight ();
		HandleJumping ();

	}

	private bool isInAir() {
		return r.velocity.y != 0;
	}
}


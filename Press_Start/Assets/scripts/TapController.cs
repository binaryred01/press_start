using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class TapController : MonoBehaviour
{
     
    public float tapForce = 10;
	public float tiltSmooth = 5;
	public Vector3 startPos;

	Rigidbody2D rigidbody;
	Quaternion downRotation;
	Quaternion forwardRotation;

    // Physics of Character
    void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
		downRotation = Quaternion.Euler(0, 0, -90);
		forwardRotation = Quaternion.Euler(0, 0, 35);
        /* This line prevents character being affected by Physics,
		ridigbody.simulated = false;
        */

	}

    // Update character when he moves
    void Update() {
        // Adding force when user presses button
        if (Input.GetMouseButtonDown(0)) {
			transform.rotation = forwardRotation;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);

		}
		// Adding falling direction then force probably when user is not pressing button
		transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);

	}

    //  Something to do with colliding with objects
    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "ScoreZone") {
            //regester score event
		}

		if (col.gameObject.tag == "DeadZone") {
			rigidbody.simulated = false;
            //register a dead event
		}
	}
}

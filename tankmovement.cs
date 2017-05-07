using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 30;
    public float number = 1;                             //通过编号区分玩家

    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    private void FixedUpdate(){
        float v = Input.GetAxis("Verticalplayer"+number);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("Horizontalplayer"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;
    }
}

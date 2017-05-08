using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 30;
    public float number = 1;                             //通过编号区分玩家
    public AudioClip idleAudio;
    public AudioClip drivingAudio;

    private Rigidbody rigidbody;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
	}

    // Update is called once per frame
    private void FixedUpdate(){
        float v = Input.GetAxis("Verticalplayer"+number);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("Horizontalplayer"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1){
            audio.clip = drivingAudio;
            if(audio.isPlaying==false)
                audio.Play();
        }
        else{
            audio.clip = idleAudio;
            if(audio.isPlaying == false)
                audio.Play();
        }
    }
}

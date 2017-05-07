using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankhealth : MonoBehaviour {

    public int bleed= 100;
    public GameObject tankExplosion;
    public AudioClip tankExplosionAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage(){
        if(bleed <= 0) return;
        bleed -= Random.Range(10, 20);
        if(bleed <= 0){
            AudioSource.PlayClipAtPoint(tankExplosionAudio,transform.position);
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}

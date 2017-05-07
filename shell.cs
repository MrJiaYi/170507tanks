﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour {

    public GameObject shellExplosionPrefab;

    public AudioClip shellExplosionAudio;



    public void OnTriggerEnter(Collider collider){
        AudioSource.PlayClipAtPoint(shellExplosionAudio,transform.position);
        GameObject.Instantiate(shellExplosionPrefab,transform.position,transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "tank"){
            collider.SendMessage("TakeDamage");
        }
        
    }
}

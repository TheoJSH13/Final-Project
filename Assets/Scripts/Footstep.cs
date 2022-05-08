using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Footstep : MonoBehaviour {

private AudioSource audioSource; 
    // Use this for initialization
    CharacterController cc;
 void Start () {
        cc = GetComponent<CharacterController>();
        
 }
 
 // Update is called once per frame
 void Update () {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            
            GetComponent<AudioSource>().Play();
            audioSource = GetComponent<AudioSource>();
            audioSource.pitch = Random.Range(1f, 1.5f);
            audioSource.volume = Random.Range(0.082f, 0.1136f);
        }
 }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelcollision : MonoBehaviour 
{
    AudioSource collision;

    private void OnTriggerEnter(Collider other) {
        collision.Play();
    }

    private void OnTriggerExit(Collider other) {
        
    }

    // Start is called before the first frame update
    void Start()
    {
          collision = GetComponent<AudioSource>();
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
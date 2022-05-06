using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gascontroller : MonoBehaviour
{

    public ParticleSystem GasCloud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider other) {
      if(other.tag == "player") {
        GasCloud.Play();
      }
    }

    private void onTriggerExit(Collider other) {
      if (other.tag == "player") {
            GasCloud.Stop();
      }
    }
}

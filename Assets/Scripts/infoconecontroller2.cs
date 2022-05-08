using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoconecontroller2 : MonoBehaviour
{
    
  
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info10").GetComponent<Text>().text = "90% of plastics currently in the ocean are directly from waste dumped into rivers! ";
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info10").GetComponent<Text>().text = "";
            
        }
    }
}
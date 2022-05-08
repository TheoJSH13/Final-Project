using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infowhalecontroller2 : MonoBehaviour
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
            GameObject.FindGameObjectWithTag("info8").GetComponent<Text>().text = "About 10% of the world’s ocean plastic pollution is made up of plastic-based fishing nets and rope. An estimated 100,000 whales will ingest these and die because of it.";
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info8").GetComponent<Text>().text = "";
            
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infobombcontroller2 : MonoBehaviour
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
            GameObject.FindGameObjectWithTag("info4").GetComponent<Text>().text = "Between 1950-1998 over 100 nuclear blast tests occurred in our oceans. Even though they were banned, nuclear residue from these tests has still been found to effect marine life. ";
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info4").GetComponent<Text>().text = "";
            
        }
    }
}
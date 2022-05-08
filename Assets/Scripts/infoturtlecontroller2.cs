using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoturtlecontroller2 : MonoBehaviour
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
            GameObject.FindGameObjectWithTag("info6").GetComponent<Text>().text = "Alot of turtles hunt jellyfish, which unfortunately look remarkably like plastic bags. Infact marine plastic pollution is found in 100% of turtles! ";
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info6").GetComponent<Text>().text = "";
            
        }
    }
}